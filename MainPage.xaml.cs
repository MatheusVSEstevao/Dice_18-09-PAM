namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        sidesPicker.SelectedIndex = 0;

    }

    public class Dice
    {
        private int numSides;

        public Dice(int numSide) 
        {
            numSides = numSide;            
        }
            
        public int RollDice()
        {
            //Random random = new Random();
            //int numeroSorteado = random.Next(1, numSides + 1);
            //return numeroSorteado;

            //int random = new Random().Next(1, numSides + 1);
            //return random;

            return new Random().Next(1, numSides + 1);
        }
       
    }

    public void OnRollClicked(object sender, EventArgs e)
    {
        //Ler o número que o usuário selecionou no picker.
        int selectedSidesNumber = (int)sidesPicker.SelectedItem;
        //Instancia um novo dado com N lados. Onde N é o número selecionado
        Dice dice = new Dice(selectedSidesNumber);
        //Chamar o método para sortear o número
        int numero = dice.RollDice();
        //Mostrar o número num label
        labelNumber.Text = numero.ToString();
    }



}

