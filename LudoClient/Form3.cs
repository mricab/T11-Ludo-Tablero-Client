using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameClient;

namespace LudoClient
{
    enum GameBoardFields
    {
        Red,
        Yellow,
        Green,
        Blue,
        Orange,
        Violet,
    }
    public partial class Form3 : Form, IGClient3
    {
        // Properties
        private GClient GameClient;
        private static Graphics drawer;
        private static GameBoardFields[,] GameBoard;
        private static int blockSize = 35;


        public Form3(GClient GameClient, String Game)
        {
            InitializeComponent();
            this.GameClient = GameClient;
            GameClient.RegisterObserver3(this);
            GameClient.Send("get board", new string[] { Game });
        }

        // Control Events
        private void CloseGameButton_Click(object sender, EventArgs e)
        {
            Invoke(LaunchMenuFormHandler, this);
            Invoke(CloseFormHandler, this);
        }

        // IGCLient3
        void IGClient3.OnGBoard(GBoardEvent e)
        {
            Invoke(DrawBoardHandler, this, e.data.board);
        }

        // Form Control
        private delegate void CloseFormDelegate(Form3 form);
        CloseFormDelegate CloseFormHandler = CloseForm;
        private static void CloseForm(Form3 form)
        {
            form.BoardPictureBox.Refresh();
            form.Dispose();
        }

        private delegate void LaunchMenuFormDelegate(Form3 form);
        LaunchMenuFormDelegate LaunchMenuFormHandler = LaunchMenuForm;
        private static void LaunchMenuForm(Form3 form)
        {
            Form2 menu = new Form2(form.GameClient);
            menu.Show();
        }

        private delegate void DrawBoardDelegate(Form3 form, string[] board);
        DrawBoardDelegate DrawBoardHandler = DrawBoard;
        public static void DrawBoard(Form3 form, string[] board)
        {            
            int size = int.Parse(board[0]);
            GameBoard = new GameBoardFields[size, size];
            form.BoardPictureBox.Image = new Bitmap(size * blockSize, size * blockSize);
            drawer = Graphics.FromImage(form.BoardPictureBox.Image);
            drawer.Clear(Color.Black);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int pos = (size * i) + j + 1;
                    drawer.DrawImage(form.BlocksImageList.Images[int.Parse(board[pos])], j * blockSize, i * blockSize);
                }
            }
        }

    }
}
