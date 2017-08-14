using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific_length_music
{
    class CPlaylist
    {
        public String name  { get; set; }
        public String path  { get; set; }
        public double duration { get; set; }//int max = 2 147 483 647

        public CPlaylist(String c_name,String c_path)
        {
            name = c_name;
            path = c_path;
            duration = GetDurationMillisecond();
        }

        private double GetDurationMillisecond()
        {
            TagLib.File file = TagLib.File.Create(path);
            return file.Properties.Duration.TotalMilliseconds;
        }

    }
}
