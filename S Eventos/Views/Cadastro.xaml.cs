using S_Eventos.Models;

namespace S_Eventos.Views;

public partial class Cadastro : ContentPage
{
    public Cadastro()
    {
        InitializeComponent();

        // Preencher o Picker com opções
        local_evento.ItemsSource = new List<string>
        {
            "Auditório Principal",
            "Salão de Festas",
            "Sala Online",
            "Outros"
        };
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        label_participantes.Text = $"{(int)e.NewValue} participantes";
    }

    private void OnEnviarClicked(object sender, EventArgs e)
    {
        var evento = new Evento
        {
            Nome = nome_evento.Text,
            DataInicio = data_inicio.Date,
            DataTermino = data_termino.Date,
            Participantes = (int)stepper_participantes.Value,
            Local = local_evento.SelectedItem?.ToString() ?? "Não informado",
            CustoPorParticipante = double.TryParse(custo_participante.Text, out double custo) ? custo : 0
        };

        Navigation.PushAsync(new Resumo(evento));
    }
}
