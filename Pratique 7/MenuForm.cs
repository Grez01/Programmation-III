using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pratique_5{
    public partial class MenuForm : Form{
        private static bool m_bot;
        private static string m_ip;
        private static bool m_client;
        public MenuForm(){
            InitializeComponent();
        }
        
        public bool Bot{
            get{
                return m_bot;
            }
            set{
                m_bot = value;
            }
        }
        public string IP{
            get{
                return m_ip;
            }
            set{
                m_ip = value;
            }
        }
        public bool Client{
            get{
                return m_client;
            }
            set{
                m_client = value;
            }
        }
        private void btNewGame_Click(object sender, EventArgs e){
            start();
        }
        private void start(){
            label.Text = "Bonne partie de TicTacToe";
            label.Left = (Size.Width / 2) - (label.Size.Width / 2);
            label.Top = pictureBox1.Top + pictureBox1.Size.Height + 5;
            TicTacToe.newPartie(Bot, Client, IP);
        }
        private void optMulti_CheckedChanged(object sender, EventArgs e){
            Bot = false;
        }

        private void optBot_CheckedChanged(object sender, EventArgs e){
            Bot = true;
        }
        private void btHost_Click(object sender, EventArgs e){
            if(!Bot){
                Client = false;
                start();
            }
        }
        private void btJoin_Click(object sender, EventArgs e){
            if(!Bot){
                Client = true;
                IP = txtJoin.Text;
                start();
                
            }
        }
    }
}