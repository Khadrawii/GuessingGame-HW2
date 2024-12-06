using System;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    partial class Form1
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(166, 62);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(169, 89);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(47, 20);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(212, 134);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            this.btnNewGame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNewGame_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(586, 295);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnNewGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnNewGame;
    }
}