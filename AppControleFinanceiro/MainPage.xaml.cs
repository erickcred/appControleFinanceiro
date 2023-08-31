namespace AppControleFinanceiro
{
  public partial class MainPage : ContentPage
  {
    int count = 0;

    public MainPage()
    {
      InitializeComponent();
    }

    private void OnCounterAnyLess(object sender, EventArgs e)
    {
      count++;

      if (count == 1)
        CounterBtn1.Text = $"Clicked {count} time";
      else
        CounterBtn1.Text = $"Clicked {count} times";
      CounterBtn2.Text = $"Cliked {count}";

      Alerta.Text = Alerta.Text.Length > 0 ? string.Empty : Alerta.Text;

      SemanticScreenReader.Announce(CounterBtn1.Text);
    }

    private void OnCounterPlus(object sender, EventArgs e)
    {

      if (count <= 0)
      {
        Alerta.Text = "Não podemos ir a menos de (0)";
      } else
      {
        count--;
        CounterBtn2.Text = $"Cliked {count}";
        CounterBtn1.Text = $"Clicked {count} time";
      }
      SemanticScreenReader.Announce(CounterBtn2.Text);
    }

  }
}