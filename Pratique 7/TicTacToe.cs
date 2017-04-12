using System;
using System.Windows.Forms;

namespace Pratique_5{
    static class TicTacToe{
        private static Music m_themes;
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Music Theme = new Music();
            Application.Run(new MenuForm());
            Theme.stop();
        }
        public static Music Themes{
            get{
                return m_themes;
            }
            set{
                m_themes = value;
            }
        }
        public static void newPartie(bool bot, bool client, string IP){
            GameTTT newGame = new GameTTT(bot, client, IP);
            if(IP != "") newGame.receive();
        }
    }
}
