namespace Projeto.Front
{

    partial class FrontPrincipal
    {
        private Button btnCriarPonto;
        private Button btnParticipar;
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
            this.btnCriarPonto = new Button();
            this.btnParticipar = new Button();

            this.SuspendLayout();

            btnCriarPonto.Text = "Criar Ponto de Doação";
            btnCriarPonto.Size = new Size(200, 50);
            btnCriarPonto.Location = new Point(300, 150);
            btnCriarPonto.Click += btnCriarPonto_Click;

            btnParticipar.Text = "Participar da Doação";
            btnParticipar.Size = new Size(200, 50);
            btnParticipar.Location = new Point(300, 220); // ↓ ajustei posição
            btnParticipar.Click += btnParticipar_Click;

            this.Controls.Add(btnCriarPonto);
            this.Controls.Add(btnParticipar);

            this.ClientSize = new Size(800, 450);
            this.Text = "Tela Principal";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
        }

        #endregion
    }
}