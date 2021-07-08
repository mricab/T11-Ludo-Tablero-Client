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
    public partial class Form2 : Form, IGClient2
    {
        GClient GameClient;
        public Form2(GClient GameClient)
        {
            InitializeComponent();
            this.GameClient = GameClient;
            GameClient.RegisterObserver2(this);
        }

        // Control Events
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GameClient.Send("logout");
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Visible = false;
            StartGameAButton.Visible = true;
            StartGameBButton.Visible = true;
            CancelStartGameButton.Visible = true;
        }

        private void StartGameAButton_Click(object sender, EventArgs e)
        {
            Invoke(LaunchGameHandler, this, "A");
            Invoke(CloseFormHandler, this);
        }

        private void StartGameBButton_Click(object sender, EventArgs e)
        {
            Invoke(LaunchGameHandler, this, "B");
            Invoke(CloseFormHandler, this);
        }

        private void CancelStartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Visible = true;
            StartGameAButton.Visible = false;
            StartGameBButton.Visible = false;
            CancelStartGameButton.Visible = false;
        }

        // IGCLient2
        void IGClient2.OnGLogout(GLogoutEvent e)
        {
            Invoke(LaunchLoginFormHandler, this);
            Invoke(CloseFormHandler, this);            
        }

        // Form Control
        private delegate void CloseFormDelegate(Form2 form);
        CloseFormDelegate CloseFormHandler = CloseForm;
        private static void CloseForm(Form2 form)
        {
            form.Close();
        }

        private delegate void LaunchLoginFormDelegate(Form2 form);
        LaunchLoginFormDelegate LaunchLoginFormHandler = LaunchLoginForm;
        private static void LaunchLoginForm(Form2 form)
        {
            Form1 login = new Form1(form.GameClient);
            login.Show();
        }

        private delegate void LaunchGameDelegate(Form2 form, String game);
        LaunchGameDelegate LaunchGameHandler = LaunchGameForm;
        private static void LaunchGameForm(Form2 form, String game)
        {
            Form3 board = new Form3(form.GameClient, game);
            board.Show();
        }


    }
}
