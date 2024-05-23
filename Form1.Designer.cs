namespace Salvaqua
{
    partial class Janela1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            horario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)horario).BeginInit();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(932, 12);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 0;
            btLogin.Text = "Load";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // horario
            // 
            horario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            horario.GridColor = SystemColors.HotTrack;
            horario.Location = new Point(12, 12);
            horario.Name = "horario";
            horario.RowHeadersWidth = 51;
            horario.Size = new Size(914, 426);
            horario.TabIndex = 1;
            // 
            // Janela1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 611);
            Controls.Add(horario);
            Controls.Add(btLogin);
            Name = "Janela1";
            Text = "Janela1";
            Load += Janela1_Load;
            ((System.ComponentModel.ISupportInitialize)horario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btLogin;
        private DataGridView horario;
    }
}
