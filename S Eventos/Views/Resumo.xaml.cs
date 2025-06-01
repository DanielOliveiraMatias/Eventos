using S_Eventos.Models;

namespace S_Eventos.Views;

public partial class Resumo : ContentPage
{
    public Resumo(Evento evento)
    {
        InitializeComponent();

        lbl_nome.Text = evento.Nome;
        lbl_data_inicio.Text = evento.DataInicio.ToString("dd/MM/yyyy");
        lbl_data_termino.Text = evento.DataTermino.ToString("dd/MM/yyyy");
        lbl_duracao.Text = evento.DuracaoEmDias + " dia(s)";
        lbl_participantes.Text = evento.Participantes.ToString();
        lbl_custo_participante.Text = $"R$ {evento.CustoPorParticipante:F2}";
        lbl_custo_total.Text = $"R$ {evento.CustoTotal:F2}";
        lbl_local.Text = evento.Local;
    }

    private void Voltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
