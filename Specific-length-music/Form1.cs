/*/////////////////////////////
Specific Length Music selector
Par Xavier Brosseau
///////////////////////////////
Description: On entre une periode de temps a combler en musique et l'app essai
De remplir cette espace pile avec le plus de musique possible et randomiser le tout

///////////////////////////////
todo:
- Un Sous-menu pour choisir l'emplacement de l'exécutable de VLC
-partir la generation de la selection dans un thread

*//////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specific_length_music
{
    public partial class Form1 : Form
    {
        const string VLC_Path = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
        const string timeStampValue = @"d\ hh\:mm\:ss\.fff";
        string alarm_path = System.IO.Directory.GetCurrentDirectory() + @"\audio\alarm10.mp3";
        List<CPlaylist> selection = new List<CPlaylist>();
        List<CPlaylist> playlist_true = new List<CPlaylist>();

        public Form1()
        {
            InitializeComponent();
            OFD.Filter = "Music Files (*.mp3, *.m4a, *.wma)|*.mp3;*.m4a;*.wma";
            FBD.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        private void Play(ref List<CPlaylist> list)
        {
            string s_playlist = "";
            foreach (CPlaylist song in list)
            {
                s_playlist += " \"" + song.path + "\"";
            }
            Process.Start(VLC_Path, s_playlist);
        }

        private void FilesToList()
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                String[] l_files = OFD.FileNames;
                foreach (String path in l_files)
                {
                    selection.Add(new CPlaylist(Path.GetFileName(path), path));
                }
            }
        }

        private List<CPlaylist> FolderToList(string sDir)
        {
            List<CPlaylist> files = new List<CPlaylist>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    if (Path.GetExtension(f) == ".mp3"
                      || Path.GetExtension(f) == ".m4a"
                      || Path.GetExtension(f) == ".wma")
                    {
                        selection.Add(new CPlaylist(Path.GetFileName(f), f));
                    }

                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    selection.AddRange(FolderToList(d));
                }
            }
            catch (System.Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }

            return files;
        }

        private void selectionToTB_List(/*ref*/ List<CPlaylist> list)
        {
            string s_playlist = "";
            foreach (CPlaylist song in list)
            {
                s_playlist += TimeSpan.FromMilliseconds(song.duration).ToString(@"hh\:mm\:ss") + "\t";
                s_playlist += song.name + "\r\n";

            }
            TB_Liste.Text = s_playlist;
        }

        private double GetListDuration(ref List<CPlaylist> list)
        {
            double totalTimeDuration = 0;
            foreach (CPlaylist song in list)
            {
                totalTimeDuration += song.duration;
            }
            return totalTimeDuration;
        }

        private List<CPlaylist> shuffleList(List<CPlaylist> list)
        {
            //Shuffle
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                CPlaylist value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        private List<CPlaylist> generate(List<CPlaylist> list, double duration, int iteration)
        {
            List<CPlaylist> playlist_best = null;
            double tempsResiduel_min = duration + 1;

            for (int i = 0; i < iteration; i++)
            {
                List<CPlaylist> tempo_list = new List<CPlaylist>();
                double tempsResiduel_temp = duration;

                list = shuffleList(list);

                for (int k = 0; k < list.Count(); k++)
                {
                    if (list[k].duration <= tempsResiduel_temp)
                    {
                        tempo_list.Add(list[k]);
                        tempsResiduel_temp -= list[k].duration;
                    }
                }

                if (tempsResiduel_temp < tempsResiduel_min)
                {
                    playlist_best = tempo_list;
                    tempsResiduel_min = tempsResiduel_temp;
                }
            }

            //Update du label temps risiduel
            LB_TempsRisiduel.Text = "Temps risiduel: " + TimeSpan.FromMilliseconds(tempsResiduel_min).ToString(timeStampValue);
            //update du label temps total
            LB_TempsTotal.Text = "Temps Total: " + TimeSpan.FromMilliseconds(GetListDuration(ref playlist_best)).ToString(timeStampValue);

            playlist_best = shuffleList(playlist_best);

            if (CB_Alert.Checked)
            {
                playlist_best.Add(new CPlaylist("----ALARM----", alarm_path));
            }

            return playlist_best;
        }

        ///////////////////////////////////////////////////////////////////
        ////////////////////////EVENT//////////////////////////////////////
        ///////////////////////////////////////////////////////////////////

        private void BTN_FilesSelector_Click(object sender, EventArgs e)
        {
            FilesToList();
            selectionToTB_List(selection);
            playlist_true = selection;
            LB_TempsTotal.Text = "Temps Total: " + TimeSpan.FromMilliseconds(GetListDuration(ref selection)).ToString(timeStampValue);
        }
        private void BTN_FolderSelector_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                selection.AddRange(FolderToList(FBD.SelectedPath));

                selectionToTB_List(selection);
                playlist_true = selection;
                LB_TempsTotal.Text = "Temps Total: " + TimeSpan.FromMilliseconds(GetListDuration(ref selection)).ToString(timeStampValue);
            }
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            //Get le temps voulu
            double timeSpace = 0; //Milliseconde total
            timeSpace = (double)NUD_H.Value * 3600000;
            timeSpace += (double)NUD_M.Value * 60000;
            timeSpace += (double)NUD_S.Value * 1000;

            double totalTimeDuration = 0;
            foreach (CPlaylist song in selection)
            {
                totalTimeDuration += song.duration;
            }

            if (timeSpace <= 0)
                MessageBox.Show("La période de temps à combler doit être suppérieur à 0");
            else if (timeSpace > totalTimeDuration) // si pas assez de musique pour combler le temps
                MessageBox.Show("Pas assez de musique sélectionn pour comblé la périod voulu");
            else
            {
                playlist_true = generate(selection, timeSpace, (int)NUD_iteration.Value);//On génère le tout
                selectionToTB_List(playlist_true);

            }
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            Play(ref playlist_true);
        }

    }
}
