using System.Net.Mime;

namespace TipCalculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator";
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        lbl15.Text = "0";
        lbl20.Text = "0";
        lbl25.Text = "0";
        lbltotal.Text = "Total:";
        lbltip.Text = "Tip:";
        bill.Text = String.Empty;
    }

    private void btn15_OnClicked(object sender, EventArgs e)
    {
        double dblbill;
        Double.TryParse(bill.Text, out dblbill);

        double tip = dblbill * 0.15;

        lbltip.Text = tip.ToString();
        lbl15.Text = tip.ToString();

        double total = dblbill + tip;

        lbltotal.Text = total.ToString();

    }

    private void Btn20_OnClicked(object sender, EventArgs e)
    {
        double dblbill;
        Double.TryParse(bill.Text, out dblbill);

        double tip = dblbill * 0.20;

        lbltip.Text = tip.ToString();
        lbl20.Text = tip.ToString();

        double total = dblbill + tip;

        lbltotal.Text = total.ToString();
    }

    private void Btn25_OnClicked(object sender, EventArgs e)
    {
        double dblbill;
        Double.TryParse(bill.Text, out dblbill);

        double tip = dblbill * 0.25;

        lbltip.Text = tip.ToString();
        lbl25.Text = tip.ToString();

        double total = dblbill + tip;

        lbltotal.Text = total.ToString();
    }
}