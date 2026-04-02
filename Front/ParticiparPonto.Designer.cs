namespace Projeto.Front
{
    partial class ParticiparPonto
    {
        private ComboBox cmbTipo;
        private TextBox txtDescricao;
        private Button btnConfirmar;

        private void InitializeComponent()
        {
            this.cmbTipo = new ComboBox();
            this.txtDescricao = new TextBox();
            this.btnConfirmar = new Button();

            this.SuspendLayout();

            // COMBO
            cmbTipo.Items.Add("dinheiro");
            cmbTipo.Items.Add("mantimento");
            cmbTipo.Location = new Point(50, 50);
            cmbTipo.Size = new Size(200, 23);

            // DESCRIÇÃO
            txtDescricao.Location = new Point(50, 100);
            txtDescricao.Size = new Size(250, 23);
            txtDescricao.PlaceholderText = "Ex: 5kg arroz ou R$50";

            // BOTÃO
            btnConfirmar.Text = "Confirmar Participação";
            btnConfirmar.Location = new Point(50, 150);
            btnConfirmar.Size = new Size(200, 40);
            btnConfirmar.Click += btnConfirmar_Click;

            // FORM
            this.ClientSize = new Size(400, 250);
            this.Text = "Participar da Doação";

            this.Controls.Add(cmbTipo);
            this.Controls.Add(txtDescricao);
            this.Controls.Add(btnConfirmar);

            this.ResumeLayout(false);
        }
    }
}