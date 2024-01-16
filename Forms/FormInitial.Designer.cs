namespace JogoGourmetDotNet.Forms
{
    partial class FormInitial
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
            labelInitial = new System.Windows.Forms.Label();
            buttonNo = new System.Windows.Forms.Button();
            buttonYes = new System.Windows.Forms.Button();
            buttonOk = new System.Windows.Forms.Button();
            textBoxQuit2 = new System.Windows.Forms.TextBox();
            textBoxQuit1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // labelInitial
            // 
            labelInitial.AutoSize = true;
            labelInitial.Location = new System.Drawing.Point(47, 24);
            labelInitial.Name = "labelInitial";
            labelInitial.Size = new System.Drawing.Size(138, 15);
            labelInitial.TabIndex = 9;
            labelInitial.Text = "Qual prato você pensou?";
            // 
            // buttonNo
            // 
            buttonNo.Location = new System.Drawing.Point(129, 64);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new System.Drawing.Size(66, 23);
            buttonNo.TabIndex = 7;
            buttonNo.Text = "Não";
            buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            buttonYes.Location = new System.Drawing.Point(35, 64);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new System.Drawing.Size(66, 23);
            buttonYes.TabIndex = 6;
            buttonYes.Text = "Sim";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new System.Drawing.Point(89, 64);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(46, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBoxQuit2
            // 
            textBoxQuit2.Location = new System.Drawing.Point(25, 42);
            textBoxQuit2.Multiline = true;
            textBoxQuit2.Name = "textBoxQuit2";
            textBoxQuit2.Size = new System.Drawing.Size(184, 23);
            textBoxQuit2.TabIndex = 11;
            textBoxQuit2.Visible = false;
            // 
            // textBoxQuit1
            // 
            textBoxQuit1.Location = new System.Drawing.Point(25, 42);
            textBoxQuit1.Multiline = true;
            textBoxQuit1.Name = "textBoxQuit1";
            textBoxQuit1.Size = new System.Drawing.Size(184, 23);
            textBoxQuit1.TabIndex = 12;
            textBoxQuit1.Visible = false;
            // 
            // FormInitial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(234, 111);
            Controls.Add(textBoxQuit1);
            Controls.Add(textBoxQuit2);
            Controls.Add(buttonOk);
            Controls.Add(labelInitial);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInitial";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Jogo Gourmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxQuit2;
        private System.Windows.Forms.TextBox textBoxQuit1;
    }
}