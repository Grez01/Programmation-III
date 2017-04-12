using System;
using System.Windows.Forms;

namespace Pratique_5{
    public partial class GameForm : Form{
        private GameTTT m_game;
        public GameForm(GameTTT game){
            InitializeComponent();
            Game = game;
        }
        public GameTTT Game{
            get{
                return m_game;
            }
            set{
                m_game = value;
            }
        }
        public void changerMessage(char player, int number){
            switch (number){
                case 1:
                    label1.Text = "C'est le tour du joueur " + player;
                    break;
                case 2:
                    label1.Text = "La case est déjà jouée joueur " + player + ", veuillez jouer autre case";
                    break;
                case 3:
                    string Player = (Game.Player == 'O') ? "X" : "O";
                    label1.Text = "Fin de la partie, victoire de : " + Player;
                    break;
            } 
        }
        private void clickPlay(object sender){
            if (Game.Partie[0] == 1){
                Game.jouerCoup(((Button)sender).Name[1] - 49);
                string Player = (Game.Player == 'O') ? "X" : "O";
                ((Button)sender).Text = Player;
            }
        }
        private void c7_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c8_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c9_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c4_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c5_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c6_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c1_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c2_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
        private void c3_Click(object sender, EventArgs e){
            clickPlay(sender);
        }
    }
}
