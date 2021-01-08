using System.Windows.Forms;

namespace UI.Services
{
    public static class BrandLoader
    {
        public static void LoadBrandImage(PictureBox pictureBox, string manufactor)
        {
            switch (manufactor)
            {
                case "Volkswagen":
                    pictureBox.Image = Properties.Resources.vw;
                    break;
                case "Chevrolet":
                    pictureBox.Image = Properties.Resources.chevy;
                    break;
                case "Fiat":
                    pictureBox.Image = Properties.Resources.fiat;
                    break;
                case "Ford":
                    pictureBox.Image = Properties.Resources.ford;
                    break;
                case "Renault":
                    pictureBox.Image = Properties.Resources.renault;
                    break;
                case "Hyundai":
                    pictureBox.Image = Properties.Resources.hyundai;
                    break;
                case "Honda":
                    pictureBox.Image = Properties.Resources.honda;
                    break;
                case "Mercedes-Benz":
                    pictureBox.Image = Properties.Resources.mercedes;
                    break;
                case "BMW":
                    pictureBox.Image = Properties.Resources.bmw;
                    break;
                case "Peugeot":
                    pictureBox.Image = Properties.Resources.peugeot;
                    break;
                case "Citroen":
                    pictureBox.Image = Properties.Resources.citroen;
                    break;
                case "Kia":
                    pictureBox.Image = Properties.Resources.kia;
                    break;
                case "Toyota":
                    pictureBox.Image = Properties.Resources.toyota;
                    break;
                case "Jeep":
                    pictureBox.Image = Properties.Resources.jeep;
                    break;
                case "Audi":
                    pictureBox.Image = Properties.Resources.audi;
                    break;
                case "Suzuki":
                    pictureBox.Image = Properties.Resources.suzuki;
                    break;
                case "Nissan":
                    pictureBox.Image = Properties.Resources.nissan;
                    break;
                case "Mitsubishi":
                    pictureBox.Image = Properties.Resources.mitsubishi;
                    break;
                case "Land Rover":
                    pictureBox.Image = Properties.Resources.land_rover;
                    break;
                case "Lexus":
                    pictureBox.Image = Properties.Resources.lexus;
                    break;
                case "Volvo":
                    pictureBox.Image = Properties.Resources.volvo;
                    break;
                case "Mini":
                    pictureBox.Image = Properties.Resources.mini;
                    break;
                case "Porsche":
                    pictureBox.Image = Properties.Resources.porsche;
                    break;
                case "Dodge":
                    pictureBox.Image = Properties.Resources.dodge;
                    break;
                case "Subaru":
                    pictureBox.Image = Properties.Resources.subaru;
                    break;
                case "Chery":
                    pictureBox.Image = Properties.Resources.chery;
                    break;
                case "Alfa Romeo":
                    pictureBox.Image = Properties.Resources.alfa_romeo;
                    break;
                case "Kawasaki":
                    pictureBox.Image = Properties.Resources.kawasaki;
                    break;
                case "Yamaha":
                    pictureBox.Image = Properties.Resources.yamaha;
                    break;
                case "Dafra":
                    pictureBox.Image = Properties.Resources.dafra;
                    break;
                case "Kasinski":
                    pictureBox.Image = Properties.Resources.kasinski;
                    break;
                case "Triumph":
                    pictureBox.Image = Properties.Resources.triumph;
                    break;
                case "Ducati":
                    pictureBox.Image = Properties.Resources.ducati;
                    break;
                case "KTM":
                    pictureBox.Image = Properties.Resources.ktm;
                    break;
                case "Scania":
                    pictureBox.Image = Properties.Resources.scania;
                    break;
                case "Iveco":
                    pictureBox.Image = Properties.Resources.iveco;
                    break;
                case "MAN":
                    pictureBox.Image = Properties.Resources.man;
                    break;
                case "Agrale":
                    pictureBox.Image = Properties.Resources.agrale;
                    break;
            }
        }
    }
}
