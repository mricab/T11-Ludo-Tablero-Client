
namespace LudoClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoutButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.StartGameAButton = new System.Windows.Forms.Button();
            this.StartGameBButton = new System.Windows.Forms.Button();
            this.CancelStartGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(473, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(92, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Cerrar Sesión";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(235, 61);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(109, 23);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Crear Partida";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // StartGameAButton
            // 
            this.StartGameAButton.Location = new System.Drawing.Point(189, 100);
            this.StartGameAButton.Name = "StartGameAButton";
            this.StartGameAButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameAButton.TabIndex = 2;
            this.StartGameAButton.Text = "Partida A";
            this.StartGameAButton.UseVisualStyleBackColor = true;
            this.StartGameAButton.Visible = false;
            this.StartGameAButton.Click += new System.EventHandler(this.StartGameAButton_Click);
            // 
            // StartGameBButton
            // 
            this.StartGameBButton.Location = new System.Drawing.Point(315, 100);
            this.StartGameBButton.Name = "StartGameBButton";
            this.StartGameBButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameBButton.TabIndex = 3;
            this.StartGameBButton.Text = "Partida B";
            this.StartGameBButton.UseVisualStyleBackColor = true;
            this.StartGameBButton.Visible = false;
            this.StartGameBButton.Click += new System.EventHandler(this.StartGameBButton_Click);
            // 
            // CancelStartGameButton
            // 
            this.CancelStartGameButton.Location = new System.Drawing.Point(392, 12);
            this.CancelStartGameButton.Name = "CancelStartGameButton";
            this.CancelStartGameButton.Size = new System.Drawing.Size(75, 23);
            this.CancelStartGameButton.TabIndex = 4;
            this.CancelStartGameButton.Text = "Cancelar";
            this.CancelStartGameButton.UseVisualStyleBackColor = true;
            this.CancelStartGameButton.Visible = false;
            this.CancelStartGameButton.Click += new System.EventHandler(this.CancelStartGameButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 200);
            this.Controls.Add(this.CancelStartGameButton);
            this.Controls.Add(this.StartGameBButton);
            this.Controls.Add(this.StartGameAButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.LogoutButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button StartGameAButton;
        private System.Windows.Forms.Button StartGameBButton;
        private System.Windows.Forms.Button CancelStartGameButton;
    }
}