using Projeto.Logical;

namespace Projeto.Front
{
    public partial class ParticiparPonto : Form
    {
        private UserParticiparService service = new UserParticiparService();

        public ParticiparPonto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Text;
            string descricao = txtDescricao.Text;

            if (string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            int userId = 1;
            int pontoId = 1;
            DateTime dataEvento = DateTime.Now.AddDays(3);

            var participacao = service.CriarParticipacao(
                userId,
                pontoId,
                tipo,
                descricao,
                dataEvento
            );

            MessageBox.Show($"Participação registrada!\nPrazo: {participacao.PrazoEnvio}");

            this.Close();
        }
    }
}