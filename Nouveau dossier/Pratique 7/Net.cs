using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Pratique_5{
    public class Net{
        System.Threading.Thread m_netThread;
        TcpListener m_heyListen;
        Socket m_socket;
        NetworkStream m_net;
        System.IO.StreamWriter m_streamWriter;
        System.IO.StreamReader m_streamReader;
        TcpClient m_link;
        GameTTT m_game;

        public Net(GameTTT game){
            //m_netThread = new System.Threading.Thread();
            m_game = game;
            m_heyListen = new TcpListener(666);
            m_heyListen.Start();
            m_socket = m_heyListen.AcceptSocket();
            if (m_socket.Connected){
                m_net = new NetworkStream(m_socket);
                m_streamWriter = new System.IO.StreamWriter(m_net);
                m_streamReader = new System.IO.StreamReader(m_net);
            }
        }
        public Net(GameTTT game, string IP){
            //m_netThread = new System.Threading.Thread();
            m_game = game;
            try{
                m_link = new TcpClient(IP, 666);
            }
            catch{
                MessageBox.Show("Votre connexion a échoué");
            }
			finally{
				m_net = m_link.GetStream();
                m_streamReader = new System.IO.StreamReader(m_net);
                m_streamWriter = new System.IO.StreamWriter(m_net);
			}
        }
        public void send(string msg){
            m_streamWriter.WriteLine(msg);
            m_streamWriter.Flush();
        }
        public string receive(){
            return "0"; //m_streamReader.ReadLine();
        }
    }
}