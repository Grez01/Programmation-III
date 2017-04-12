using System;
using System.Threading;

namespace Pratique_5
{
    public class Music{
        private System.Threading.Thread m_musicThread;
        public Music(byte param = 1){
            MusicThread = (param == 1)? new System.Threading.Thread(theme): new System.Threading.Thread(victory);
            MusicThread.Start();
        }
        public System.Threading.Thread MusicThread{
            get{
                return m_musicThread;
            }
            set{
                m_musicThread = value;
            }
        }
        public void theme(){
            while(true){
                Console.Beep(658, 125);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(500);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(500);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
            }
        }
        public void victory()
        {
            Console.Beep(880, 500);
            Console.Beep(587, 1000);
            Console.Beep(698, 500);
            Console.Beep(880, 500);
            Console.Beep(587, 1000);
            Console.Beep(698, 500);
            Console.Beep(880, 250);
            Console.Beep(1046, 250);
            Console.Beep(987, 500);
            Console.Beep(783, 500);
            Console.Beep(698, 250);
            Console.Beep(763, 250);
            Console.Beep(880, 500);
            Console.Beep(587, 500);
            Console.Beep(523, 250);
            Console.Beep(659, 250);
            Console.Beep(587, 750);
        }
        public void stop()
        {
            MusicThread.Abort();
        }
    }
}
