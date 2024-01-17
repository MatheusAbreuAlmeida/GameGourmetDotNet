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
            buttonCancel = new System.Windows.Forms.Button();
            buttonOkQuit2 = new System.Windows.Forms.Button();
            textBoxQuit2 = new System.Windows.Forms.TextBox();
            textBoxQuit1 = new System.Windows.Forms.TextBox();
            buttonOkQuit1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelInitial
            // 
            labelInitial.AutoSize = true;
            labelInitial.Location = new System.Drawing.Point(25, 20);
            labelInitial.Name = "labelInitial";
            labelInitial.Size = new System.Drawing.Size(138, 15);
            labelInitial.TabIndex = 9;
            labelInitial.Text = "Qual prato você pensou?";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(131, 67);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(66, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += Close;
            // 
            // buttonOkQuit2
            // 
            buttonOkQuit2.Location = new System.Drawing.Point(32, 67);
            buttonOkQuit2.Name = "buttonOkQuit2";
            buttonOkQuit2.Size = new System.Drawing.Size(66, 23);
            buttonOkQuit2.TabIndex = 6;
            buttonOkQuit2.Text = "Ok";
            buttonOkQuit2.UseVisualStyleBackColor = true;
            buttonOkQuit2.Visible = false;
            buttonOkQuit2.Click += buttonOkQuit2_Click;
            // 
            // textBoxQuit2
            // 
            textBoxQuit2.Location = new System.Drawing.Point(25, 38);
            textBoxQuit2.Multiline = true;
            textBoxQuit2.Name = "textBoxQuit2";
            textBoxQuit2.Size = new System.Drawing.Size(184, 23);
            textBoxQuit2.TabIndex = 11;
            textBoxQuit2.Visible = false;
            // 
            // textBoxQuit1
            // 
            textBoxQuit1.Location = new System.Drawing.Point(25, 38);
            textBoxQuit1.Multiline = true;
            textBoxQuit1.Name = "textBoxQuit1";
            textBoxQuit1.Size = new System.Drawing.Size(184, 23);
            textBoxQuit1.TabIndex = 12;
            textBoxQuit1.Visible = false;
            // 
            // buttonOkQuit1
            // 
            buttonOkQuit1.Location = new System.Drawing.Point(32, 67);
            buttonOkQuit1.Name = "buttonOkQuit1";
            buttonOkQuit1.Size = new System.Drawing.Size(66, 23);
            buttonOkQuit1.TabIndex = 13;
            buttonOkQuit1.Text = "Ok";
            buttonOkQuit1.UseVisualStyleBackColor = true;
            buttonOkQuit1.Visible = false;
            buttonOkQuit1.Click += buttonOkQuit1_Click;
            // 
            // FormInitial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(234, 111);
            Controls.Add(buttonOkQuit1);
            Controls.Add(textBoxQuit1);
            Controls.Add(textBoxQuit2);
            Controls.Add(labelInitial);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOkQuit2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInitial";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk2;
        private System.Windows.Forms.Button buttonOkQuit2;
        private System.Windows.Forms.Button buttonOkQuit1;
    }
}