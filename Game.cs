using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCL.Net;

namespace PcGameChecker
{
    [Serializable]
    class Game
    {
        private string Name;
        private string Description;
        private uint Year;
        private string Genre;
        private Image Poster;
        private string Req_OS;
        private string Req_OS_Architecture;
        private string Req_disk_space;

        private uint metacritic;
        private double user_score;

        private uint Min_Processor_Cores;
        private uint Min_Processor_Threads;
        private uint Min_Processor_Clock; // Mhz
        private uint Min_Graphics_VRAM; // MB
        private uint Min_Graphics_Gpu_Clock;

        private uint Rec_Processor_Cores;
        private uint Rec_Processor_Threads;
        private uint Rec_Processor_Clock; // Mhz
        private uint Rec_Graphics_VRAM; // MB
        private uint Rec_Graphics_Gpu_Clock;
        public Game(string g_name, string g_desc, uint g_year, string g_genre, Image g_post_dir, string g_os, uint g_meta, double g_user_score,
            string g_osa, string g_ds, uint g_mp_cores, uint g_mp_threads, uint g_mp_clock_mhz, uint g_mg_vram, uint g_mg_clock)
        {
            Name = g_name;
            Description = g_desc;
            Year = g_year;
            Genre = g_genre;
            Poster = g_post_dir;
            Req_OS = g_os;
            Req_OS_Architecture = g_osa;
            Req_disk_space = g_ds;

            metacritic = g_meta;
            user_score = g_user_score;

            Min_Processor_Cores = g_mp_cores;
            Min_Processor_Threads = g_mp_threads;
            Min_Processor_Clock = g_mp_clock_mhz;
            Min_Graphics_VRAM = g_mg_vram;
            Min_Graphics_Gpu_Clock = g_mg_clock;
        }
        public void AddRec(uint g_rp_cores, uint g_rp_threads, uint g_rp_clock_mhz, uint g_rg_vram, uint g_rg_clock)
        {
            Rec_Processor_Cores = g_rp_cores;
            Rec_Processor_Threads = g_rp_threads;
            Rec_Processor_Clock = g_rp_clock_mhz;
            Rec_Graphics_VRAM = g_rg_vram;
            Rec_Graphics_Gpu_Clock = g_rg_clock;
        }
    }
}
