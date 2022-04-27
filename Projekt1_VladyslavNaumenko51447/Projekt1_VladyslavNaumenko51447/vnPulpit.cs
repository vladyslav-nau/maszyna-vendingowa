using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_VladyslavNaumenko51447
{
    public partial class vnPulpit : Form
    {
        public vnPulpit()
        {
            InitializeComponent();
        }
        Panel vnEEpanel = new Panel();
        Button vnEEbutton = new Button();
        private void vnbtnAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witam! Ten projekt zaprojektowal Vladyslav Naumenko (51447).", "Autor");


            // easter egg
            vnEEpanel.Location = new Point(10, 200);
            vnEEpanel.BackColor = Color.Black;
            vnEEbutton.BackColor = SystemColors.Control;
            vnEEbutton.BackgroundImage = Properties.Resources.Zolotysti;
            vnEEbutton.BackgroundImageLayout = ImageLayout.Zoom;
            vnEEbutton.Dock = DockStyle.Fill;
            vnEEbutton.Click += new System.EventHandler(this.vnZolotysti_Click);
            vnEEpanel.Controls.Add(vnEEbutton);
            Controls.Add(vnEEpanel);
        }

        private void vnPulpit_Load(object sender, EventArgs e)
        {
            vnAktywacja.vnAktywacjaControlki(new Control[] { vnPanelWybierzRodzajWaluty, vnPbValute });
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelWybierzRodzajPlatności);
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelWrzućMonete);
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelWrzuconaIlośćPieniędz);
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelZaplaćGotówką);
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelKwotaDoZaplaty);
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelZaplacićKartą);
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnDeaktywizacjaControlki(vnEEpanel);

        }

        private void vnTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jak korzystać się tej programą!" + "\n" +
                "1. Najpierw  musicie wybrać valute w jaką państwo będzie oplaciwali." + "\n" +
                "2. Teraz wybieracie produkt, jaki chcecie odebrać." + "\n" +
                "3. Wybieracie rodzaj platności." + "\n"
                +"\t" + "a. Jeśli obrali zaplacić gotówką - wrzucacie monete." + "\n"
                + "\t" + "b. Jeśli obrali kartu, wtedy oplacicie kartą." + "\n" + "\n" +
                "EASTER EGG. Autor zna, co lubi kupować. Spytacie jego ^_^."
                , "Jak korzystać się tej programą!");
        }

        private void vnFanta_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem1.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();
        }

        private void vnCocaCola_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem2.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();

        }

        private void vnSprite_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem3.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();

        }

        private void vnSnikers_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem4.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();

        }

        private void vnTwix_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem5.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();

        }
        private void vnMilkiway_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem6.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();


        }
        private void vnZolotysti_Click(object sender, EventArgs e)
        {
            vnAktywacja.vnDeaktywizacjaControlki(vnFlpProdukty);
            vnAktywacja.vnDeaktywizacjaControlki(vnEEpanel);
            vnAktywacja.vnAktywacjaControlki(vnPanelWybierzRodzajPlatności);

            vnMoneySystem.vnMoney.vnCurrentAmountToPay = vnItemSystem.vnItem7.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue;
            vnTbKwotaDoZaplaty.Text = vnMoneySystem.vnMoney.vnCurrentAmountToPay.ToString();


        }
        private void vnCmbRodzajWaluty_SelectedIndexChanged(object sender, EventArgs e)
        {
            vnMoneySystem.vnPLN vnPln = new vnMoneySystem.vnPLN();
            vnMoneySystem.vnUAH vnUah = new vnMoneySystem.vnUAH();
            vnMoneySystem.vnBYN vnByn = new vnMoneySystem.vnBYN();
            vnMoneySystem.vnRUB vnRub = new vnMoneySystem.vnRUB();
            vnMoneySystem.vnEUR vnEur = new vnMoneySystem.vnEUR();
            vnMoneySystem.vnUSD vnUsd = new vnMoneySystem.vnUSD();

            switch (vnCmbRodzajWaluty.SelectedItem)
            {
                case "PLN": { vnPbValute.BackgroundImage = Properties.Resources.PLN; vnMoneySystem.vnMoney.vnCurrValute = vnPln; break; };
                case "UAH": { vnPbValute.BackgroundImage = Properties.Resources.UAH; vnMoneySystem.vnMoney.vnCurrValute = vnUah; break; };
                case "BYN": { vnPbValute.BackgroundImage = Properties.Resources.BYN; vnMoneySystem.vnMoney.vnCurrValute = vnByn; break; };
                case "RUB": { vnPbValute.BackgroundImage = Properties.Resources.RUB; vnMoneySystem.vnMoney.vnCurrValute = vnRub; break; };
                case "EUR": { vnPbValute.BackgroundImage = Properties.Resources.EUR; vnMoneySystem.vnMoney.vnCurrValute = vnEur; break; };
                case "USD": { vnPbValute.BackgroundImage = Properties.Resources.USD; vnMoneySystem.vnMoney.vnCurrValute = vnUsd; break; };
            }

            vnSnickersLabel.Text = (vnItemSystem.vnItem4.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;
            vnTwixLabel.Text = (vnItemSystem.vnItem5.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;
            vnMilkiwayLabel.Text = (vnItemSystem.vnItem6.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;
            vnFantaLabel.Text = (vnItemSystem.vnItem1.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;
            vnCocaColaLabel.Text = (vnItemSystem.vnItem2.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;
            vnSpriteLabel.Text = (vnItemSystem.vnItem3.vnItemValue * vnMoneySystem.vnMoney.vnCurrentValute.vnValuteValue).ToString() + "\n" + vnMoneySystem.vnMoney.vnCurrentValute.vnValuteCode;

            vnAktywacja.vnAktywacjaControlki(vnFlpProdukty);
            vnAktywacja.vnAktywacjaControlki(vnEEpanel);
            vnAktywacja.vnDeaktywizacjaControlki(new Control[] { vnPanelWybierzRodzajWaluty, vnPbValute });
        }

        private void vnV050_Click(object sender, EventArgs e)
        {
            vnMoneySystem.vnMoney.vnCurrentPaymentValue += 0.5;
            vnTbWrzuconaIlośćPienięd.Text = vnMoneySystem.vnMoney.vnCurrentPaymentValue.ToString();
        }

        private void vnV100_Click(object sender, EventArgs e)
        {
            vnMoneySystem.vnMoney.vnCurrentPaymentValue += 1;
            vnTbWrzuconaIlośćPienięd.Text = vnMoneySystem.vnMoney.vnCurrentPaymentValue.ToString();

        }

        private void vnV200_Click(object sender, EventArgs e)
        {
            vnMoneySystem.vnMoney.vnCurrentPaymentValue += 2;
            vnTbWrzuconaIlośćPienięd.Text = vnMoneySystem.vnMoney.vnCurrentPaymentValue.ToString();

        }

        private void vnV500_Click(object sender, EventArgs e)
        {
            vnMoneySystem.vnMoney.vnCurrentPaymentValue += 5;
            vnTbWrzuconaIlośćPienięd.Text = vnMoneySystem.vnMoney.vnCurrentPaymentValue.ToString();

        }

        private void vnCmbWybierzRodzajPlatności_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(String.Equals(vnCmbRodzajPlatności.SelectedItem, "Gotówką"))
            {
                vnAktywacja.vnAktywacjaControlki(new Control[] { vnPanelWrzućMonete, vnPanelWrzuconaIlośćPieniędz, vnPanelZaplaćGotówką });
            }
            else if (String.Equals(vnCmbRodzajPlatności.SelectedItem, "Kartą"))
            {
                vnAktywacja.vnAktywacjaControlki(vnPanelZaplacićKartą);
            }
            vnAktywacja.vnDeaktywizacjaControlki(vnPanelWybierzRodzajPlatności);
            vnAktywacja.vnAktywacjaControlki(vnPanelKwotaDoZaplaty);
        }

        private void vnZaplacićGotówką_Click(object sender, EventArgs e)
        {
            if ((vnMoneySystem.vnMoney.vnCurrentPaymentValue - vnMoneySystem.vnMoney.vnCurrentAmountToPay) >=0)
            {
                MessageBox.Show($"Dziękujemy! Wasza reszta: {vnMoneySystem.vnMoney.vnCurrentPaymentValue - vnMoneySystem.vnMoney.vnCurrentAmountToPay}");

                Application.Exit();
            }
            else
            {
                MessageBox.Show($"Wrzucicie więcej pieniędz!");
            }
        }

        private void vnZaplacićKartą_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dziękujemy! Zawsze czekamy na was, dobrego dnia!");

            Application.Exit();
        }

        private void vnWrzuconaIlośćPieniędz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
