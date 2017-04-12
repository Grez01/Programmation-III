using System;
using Bot_TicTacToe;

namespace Pratique_5{
    public class GameTTT {
        public const char VIDE = ' ';
        public const char X = 'X';
        public const char O = 'O';
        private byte m_count;
        private char[] m_game;
        private byte[] m_partie;//Partie[0] = Partie continue ou non / Partie[1] = le gagnant / Partie[2] = bot
        private bool m_bot;
        private bool m_multi;
        private GameForm m_affichage;
        private char m_player;
        private Net m_connexion;

        public GameTTT(bool bot, bool Client, string IP) {
            Affichage = new GameForm(this);
            if (IP != "") Player = 'O';
            else Player = X;
            Affichage.Show();
            Game = new char[9];
            Partie = new byte[3];
            Count = 9;
            if (bot) Bot_Ai = bot;
            else {
                Connexion = (Client) ? new Net(this, IP) : new Net(this);
                Multi = !bot;
            }
            Partie[0] = 1;
            Partie[1] = 0;
            Partie[2] = (Bot_Ai) ? Convert.ToByte(1) : Convert.ToByte(0);
            for (byte a = 0; a < 9; ++a) Game[a] = VIDE;
        }
        public byte Count {
            get {
                return m_count;
            }
            set {
                m_count = value;
            }
        }
        public char[] Game {
            get {
                return m_game;
            }
            set {
                m_game = value;
            }
        }
        public byte[] Partie {
            get {
                return m_partie;
            }
            set {
                m_partie = value;
            }
        }
        public bool Bot_Ai
        {
            get {
                return m_bot;
            }
            set {
                m_bot = value;
            }
        }
        public GameForm Affichage
        {
            get
            {
                return m_affichage;
            }
            set
            {
                m_affichage = value;
            }
        }
        public char Player
        {
            get {
                return m_player;
            }
            set {
                m_player = value;
            }
        }
        public Net Connexion {
            get {
                return m_connexion;
            }
            set {
                m_connexion = value;
            }
        }
        public bool Multi {
            get {
                return m_multi;
            }
            set {
                m_multi = value;
            }
        }
        public void receive() {
            jouerCoup(Convert.ToInt32(Connexion.receive()));
        }
        public void jouerCoup(int coup){
            if(Partie[0] == 1){
                int position = 0;
                if(Multi) position = coup;
                else position = ((Bot_Ai && Player == O) ^ (!Bot_Ai)) ? coup : Bot.botPlay();
                byte errCode = 1;
                if (Game[position] == VIDE){
                    Game[position] = Player;
                    --Count;
                }
                else errCode = Convert.ToByte(errCode << 1);
                if (errCode == 1) {
                    if (Player == 'X') Connexion.send(Convert.ToString(coup));
                    changerJoueur();
                    if (verifierPartie()[0] == 0) finPartie();
                }
                Affichage.changerMessage(Player, errCode);
            }
        }
        public void changerJoueur(){
            Player = (Player == 'O') ? X : O;
        }
        public void finPartie(){
            Affichage.changerMessage(Player, 3);
        }
        byte[] verifierPartie(){//O(n)
            if (Count < 5){
                if (Game[0] != VIDE && Game[0] == Game[1] && Game[0] == Game[2] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[0] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[3] != VIDE && Game[3] == Game[4] && Game[3] == Game[5] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[3] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[6] != VIDE && Game[6] == Game[7] && Game[6] == Game[8] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[6] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[0] != VIDE && Game[0] == Game[3] && Game[0] == Game[6] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[0] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[1] != VIDE && Game[1] == Game[4] && Game[1] == Game[7] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[1] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[2] != VIDE && Game[2] == Game[5] && Game[2] == Game[8] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[2] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[0] != VIDE && Game[0] == Game[4] && Game[0] == Game[8] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[0] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Game[2] != VIDE && Game[2] == Game[4] && Game[2] == Game[6] && Partie[0] == 1){
                    Partie[0] = 0;
                    Partie[1] = (Game[2] == X) ? Convert.ToByte(1) : Convert.ToByte(2);
                }
                if (Count == 0) Partie[0] = 0;
            }
            return Partie;
        }
    }
}//*/