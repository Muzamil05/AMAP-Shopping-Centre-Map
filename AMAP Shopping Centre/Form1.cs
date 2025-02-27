using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Speech.Synthesis;

namespace AMAP_Digital_Signs_solution
{
    public partial class AMAP : Form
    {
        SpeechSynthesizer voice = null;
        public AMAP()
        {
            InitializeComponent();
            listcollection.Clear();
            foreach (string str in Searchlistbox.Items)
            {
                listcollection.Add(str);
            }
        }

        private void Languages_Load(object sender, EventArgs e)
        {
            LanguagePanel.Visible = true;
            MainPanel.Visible = false;
            voice = new SpeechSynthesizer();
            //Creating custom fonts
            PrivateFontCollection OpenSans = new PrivateFontCollection();
            PrivateFontCollection ProximaNova = new PrivateFontCollection();

            //Open sans
            OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
            lblSelect.Font = new Font(OpenSans.Families[0], 15, FontStyle.Bold);
            lblMainText.Font = new Font(OpenSans.Families[0], 15, FontStyle.Bold);

            //Proxima nova
            ProximaNova.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\Proxima Nova Font.otf");
            Searchlbl.Font = new Font(ProximaNova.Families[0], 9);
            Parkinglbl.Font = new Font(ProximaNova.Families[0], 9);
            Banklbl.Font = new Font(ProximaNova.Families[0], 9);
            Shopslbl.Font = new Font(ProximaNova.Families[0], 8);
            Foodlbl.Font = new Font(ProximaNova.Families[0], 9);
            Discountlbl.Font = new Font(ProximaNova.Families[0], 9);
            Disabledlbl.Font = new Font(ProximaNova.Families[0], 8);
            Disabledlbl2.Font = new Font(ProximaNova.Families[0], 7);
            FireExitlbl.Font = new Font(ProximaNova.Families[0], 9);
            Helplbl.Font = new Font(ProximaNova.Families[0], 9);
        }

        //changing the text of each language
        private void ChangeLanguage(int language)
        {
            if (language == 1) //English
            {
                //Language select
                lblSelect.Text = "Please select a language:";
                //Main Map
                lblMainText.Text = "Where would you like to go?";
                //Main Map lables
                Searchlbl.Text = "Search";
                Parkinglbl.Text = "Parking";
                Banklbl.Text = "Banks";
                Shopslbl.Text = "Shops";
                Foodlbl.Text = "Food";
                Discountlbl.Text = "Discounts";
                Disabledlbl.Text = "Disabled";
                Disabledlbl2.Text = "Facilities";
                FireExitlbl.Text = "Fire exits";
                Helplbl.Text = "Help";
                //Accessibility lables
                Textlbl.Text = "Text";
                sizelbl.Text = "Size";
                Changelbl.Text = "Change";
                Languagelbl.Text = "Language";
                TextTolbl.Text = "Text-To";
                Speachlbl.Text = "Speech";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Font = new Font(OpenSans.Families[0], 12);
                lblParking.Text = "The car park is located behind Poundland.";
                lblBanks.Font = new Font(OpenSans.Families[0], 12);
                lblBanks.Text = "All banks are located on crown street.";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 10);
                Accessibilitylbl.Text = "The accessibility lift is located near the toilets.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 13);
                lblFireExit.Text = "These are the nearest fire exits.";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 13);
                lblTextOutput.Text = "Click on any text to read it out loud.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 10);
                lblInstructions.Text = "-The map shown is the Map of the entire shopping disctrict.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions2.Text = "-You can select where to go using the buttons at the bottom of the screen";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions3.Text = "or you can search where to go using the search button.";
                //Shop lables
                CategoryCombBox.Items.Add("Fashion");
                CategoryCombBox.Items.Add("Groceries");
                CategoryCombBox.Items.Add("Electronics");

            }
            else if (language == 2) //Arabic
            {
                //Language Select
                lblSelect.Text = "يرجى تحديد لغة";
                //Main Map
                lblMainText.Text = "أين تريد أن تذهب؟";
                //Main Map lables
                Searchlbl.Text = "يبحث";
                Parkinglbl.Text = "موقف سيارات";
                Parkinglbl.Location = new Point(119, 636);
                Banklbl.Text = "بنك";
                Shopslbl.Text = "محلات";
                Foodlbl.Text = "طعام";
                Discountlbl.Text = "الخصومات";
                Disabledlbl.Text = "عاجز";
                Disabledlbl2.Text = "مرافق";
                FireExitlbl.Text = "مخرج الحرائق";
                Helplbl.Text = "يساعد";
                //Accessiblility lables
                Textlbl.Text = "نص";
                sizelbl.Text = "مقاس";
                Changelbl.Text = "يتغير";
                Languagelbl.Text = "لغة";
                TextTolbl.Text = "نص إلى";
                Speachlbl.Text = "خطاب";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Font = new Font(OpenSans.Families[0], 12);
                lblParking.Text = "Poundland يقع موقف السيارات في الخلف";
                lblBanks.Font = new Font(OpenSans.Families[0], 12);
                lblBanks.Text = "Crown Street تقع جميع البنوك في";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 12);
                Accessibilitylbl.Text = "يقع مصعد الوصول بالقرب من دورات المياه.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 13);
                lblFireExit.Text = "هذه هي أقرب مخارج الحريق";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 13);
                lblTextOutput.Text = "انقر فوق أي نص لقراءته بصوت عالٍ.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 12);
                lblInstructions.Text = "- الخريطة الموضحة هي خريطة منطقة التسوق بأكملها.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 12);
                lblInstructions2.Text = "-يمكنك تحديد المكان الذي تريد الذهاب إليه باستخدام الأزرار الموجودة أسفل الشاشة";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 12);
                lblInstructions3.Text = "أو يمكنك البحث عن المكان الذي تريد الذهاب إليه باستخدام زر البحث.";
                //Shop lables
                CategoryCombBox.Items.Add("موضة");
                CategoryCombBox.Items.Add("البقالة");
                CategoryCombBox.Items.Add("إلكترونيات");
            }
            else if (language == 3) //Polish
            {
                //Language Select
                lblSelect.Text = "Proszę wybierz język";
                //Main Map
                lblMainText.Text = "Gdzie chciałbyś pójść?";
                //Main Map lables
                Searchlbl.Text = "Szukaj";
                Parkinglbl.Text = "Parking";
                Banklbl.Text = "Banks";
                Shopslbl.Text = "Sklepy";
                Foodlbl.Text = "Żywność";
                Discountlbl.Text = "Zniżki";
                Disabledlbl.Text = "Wyłączony";
                Disabledlbl2.Text = "Udogodnienia";
                FireExitlbl.Text = "Wyjście pożarowe";
                Helplbl.Text = "Pomoc";
                //Accessiblility lables
                Textlbl.Text = "Tekst";
                sizelbl.Text = "Rozmiar";
                Changelbl.Text = "Zmiana";
                Languagelbl.Text = "Język";
                TextTolbl.Text = "Wyślij SMS-a do";
                Speachlbl.Text = "Przemówienie";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Visible = true;
                lblParking.Font = new Font(OpenSans.Families[0], 7);
                lblParking.Text = "Parking znajduje się z tyłu Poundland";
                lblBanks.Font = new Font(OpenSans.Families[0], 10);
                lblBanks.Text = "Wszystkie banki znajdują się na Crown Street";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 7);
                Accessibilitylbl.Text = "Winda dla osób niepełnosprawnych znajduje się w pobliżu toalet.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 10);
                lblFireExit.Text = "To są najbliższe wyjścia ewakuacyjne.";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 10);
                lblTextOutput.Text = "Kliknij dowolny tekst, aby przeczytać go na głos.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 10);
                lblInstructions.Text = "-Pokazana mapa jest mapą całej dzielnicy handlowej.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions2.Text = "-Możesz wybrać, gdzie się udać, używając przycisków na dole ekranu";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions3.Text = "lub możesz wyszukać, gdzie się udać, używając przycisku wyszukiwania.";
                //Shop lables
                CategoryCombBox.Items.Add("Moda");
                CategoryCombBox.Items.Add("Artykuły spożywcze");
                CategoryCombBox.Items.Add("Elektronika");
            }
            else if (language == 4) //German
            {
                //Language Select
                lblSelect.Text = "Bitte wähle eine Sprache:";
                //Main Map
                lblMainText.Text = "Wo würdest du gerne hingehen?";
                //Main Map Lables
                Searchlbl.Text = "Suchen";
                Parkinglbl.Text = "Parken";
                Banklbl.Text = "Banken";
                Shopslbl.Text = "Geschäfte";
                Foodlbl.Text = "Essen";
                Discountlbl.Text = "Rabatt";
                Disabledlbl.Text = "Behinderte";
                Disabledlbl2.Text = "Einrichtungen";
                FireExitlbl.Text = "Notausgang";
                Helplbl.Text = "Hilfe";
                //Accessibility lables
                Textlbl.Text = "Text";
                sizelbl.Text = "Größe";
                Changelbl.Text = "Ändern";
                Languagelbl.Text = "Sprache";
                TextTolbl.Text = "Text an";
                Speachlbl.Text = "Rede";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Visible = true;
                lblParking.Font = new Font(OpenSans.Families[0], 10);
                lblParking.Text = "Der Parkplatz befindet sich dahinter Poundland";
                lblBanks.Font = new Font(OpenSans.Families[0], 10);
                lblBanks.Text = "Alle Banken befinden sich auf Crown Straße";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 7);
                Accessibilitylbl.Text = "Der barrierefreie Aufzug befindet sich in der Nähe der Toiletten.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 10);
                lblFireExit.Text = "Dies sind die nächsten Feuerausgänge";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 8);
                lblTextOutput.Text = "Klicken Sie auf einen beliebigen Text, um ihn laut vorzulesen.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions.Text = "-Die angezeigte Karte ist die Karte des gesamten Einkaufsviertels.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 6);
                lblInstructions2.Text = "-Mit den Schaltflächen am unteren Bildschirmrand können Sie auswählen, wohin Sie gehen möchten";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 6);
                lblInstructions3.Text = "Alternativ können Sie mithilfe der Suchschaltfläche suchen, wohin Sie gehen sollen.";
                //Shop lables
                CategoryCombBox.Items.Add("Mode");
                CategoryCombBox.Items.Add("Lebensmittel");
                CategoryCombBox.Items.Add("Elektronik");
            }
            else if (language == 5) //French
            {
                //Language Select
                lblSelect.Text = "Veuillez sélectionner une langue:";
                //Main Map
                lblMainText.Text = "Où voudrais-tu aller?";
                //Main map lables
                Searchlbl.Text = "Recherche";
                Parkinglbl.Text = "Parking";
                Banklbl.Text = "Banques";
                Shopslbl.Text = "Magasins";
                Foodlbl.Text = "Nourriture";
                Discountlbl.Text = "Rabais";
                Disabledlbl.Text = "Désactivé";
                Disabledlbl2.Text = "Installations";
                FireExitlbl.Text = "Sortie de secours";
                Helplbl.Text = "Aider";
                //Accessibility lables
                Textlbl.Text = "Texte";
                sizelbl.Text = "Taille";
                Changelbl.Text = "Changement";
                Languagelbl.Text = "Langue";
                TextTolbl.Text = "Envoyer par SMS";
                Speachlbl.Text = "Discours";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Visible = true;
                lblParking.Font = new Font(OpenSans.Families[0], 12);
                lblParking.Text = "Le parking est situé derrière Poundland";
                lblBanks.Font = new Font(OpenSans.Families[0], 9);
                lblBanks.Text = "Toutes les banques sont situées dans la rue Crown Street";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 8);
                Accessibilitylbl.Text = "L'ascenseur d'accessibilité est situé à proximité des toilettes.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 9);
                lblFireExit.Text = "Ce sont les sorties de secours les plus proches.";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 9);
                lblTextOutput.Text = "Cliquez sur n'importe quel texte pour le lire à voix haute.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 8);
                lblInstructions.Text = "-La carte affichée est la carte de l'ensemble du quartier commerçant.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 8);
                lblInstructions2.Text = "-Vous pouvez sélectionner où aller en utilisant les boutons en bas de l'écran";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 8);
                lblInstructions3.Text = "ou vous pouvez rechercher où aller en utilisant le bouton de recherche.";
                //Shop lables
                CategoryCombBox.Items.Add("Mode");
                CategoryCombBox.Items.Add("Épiceries");
                CategoryCombBox.Items.Add("Électronique");
            }
            else if (language == 6) //Spanish
            {
                //Language Select
                lblSelect.Text = "Por favor, seleccione un idioma:";
                //Main Map
                lblMainText.Text = "Dónde te gustaría ir?";
                //Main Map lables
                Searchlbl.Text = "Buscar";
                Parkinglbl.Location = new Point(105, 636);
                Parkinglbl.Text = "Estacionamiento";
                Banklbl.Text = "Bancos";
                Shopslbl.Text = "tiendas";
                Foodlbl.Text = "Alimento";
                Discountlbl.Text = "Descuentos";
                Disabledlbl.Text = "Instalaciones";
                Disabledlbl2.Text = "discapacitados";
                FireExitlbl.Text = "Salida de incendios";
                Helplbl.Text = "Ayuda";
                //Accessibility lables
                Textlbl.Text = "texto";
                sizelbl.Text = "Tamaño";
                Changelbl.Text = "Cambiar";
                Languagelbl.Text = "Idioma";
                TextTolbl.Text = "Texto a";
                Speachlbl.Text = "Discurso";
                //Button Lables
                PrivateFontCollection OpenSans = new PrivateFontCollection();
                OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
                lblParking.Visible = true;
                lblParking.Font = new Font(OpenSans.Families[0], 10);
                lblParking.Text = "El aparcamiento se encuentra detrás Poundland";
                lblBanks.Font = new Font(OpenSans.Families[0], 8);
                lblBanks.Text = "Toutes les banques sont situées dans la rue Crown Street";
                Accessibilitylbl.Font = new Font(OpenSans.Families[0], 9);
                Accessibilitylbl.Text = "El ascensor de accesibilidad se encuentra cerca de los aseos.";
                lblFireExit.Font = new Font(OpenSans.Families[0], 10);
                lblFireExit.Text = "Estas son las salidas de emergencia más cercanas.";
                lblTextOutput.Font = new Font(OpenSans.Families[0], 10);
                lblTextOutput.Text = "Haga clic en cualquier texto para leerlo en voz alta.";
                lblInstructions.Font = new Font(OpenSans.Families[0], 9);
                lblInstructions.Text = "-El mapa que se muestra es el Mapa de todo el distrito comercial.";
                lblInstructions2.Font = new Font(OpenSans.Families[0], 7);
                lblInstructions2.Text = "-Puedes seleccionar a dónde ir usando los botones en la parte inferior de la pantalla";
                lblInstructions3.Font = new Font(OpenSans.Families[0], 7);
                lblInstructions3.Text = "o puede buscar a dónde ir usando el botón de búsqueda.";
                //Shop lables
                CategoryCombBox.Items.Add("Moda");
                CategoryCombBox.Items.Add("Comestibles");
                CategoryCombBox.Items.Add("Electrónica");
            }
            LanguagePanel.Visible = false;
            MainPanel.Visible = true;
        }
        //Changing the language when the user clicks the flag.
        private void picboxEngland_Click(object sender, EventArgs e)
        {
            ChangeLanguage(1);
        }

        private void picboxGerman_Click(object sender, EventArgs e)
        {
            ChangeLanguage(4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeLanguage(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeLanguage(3);
        }
        private void picBoxFrench_Click(object sender, EventArgs e)
        {
            ChangeLanguage(5);
        }

        private void PicBoxSpanish_Click(object sender, EventArgs e)
        {
            ChangeLanguage(6);
        }

        private void Shoppingbtn_Click(object sender, EventArgs e)
        {
            Foodpnl.Visible = false;
            Discountpnl.Visible = false;
            Shoppingpnl.Visible = true;

        }

        private void Disabledlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Discountlbl.Text);
        }

        private void HambrgMenu_Click(object sender, EventArgs e)
        {
            MoreOptionspnl.Visible = true;
        }
        //hiding/showing redundant panels and lables
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            MoreOptionspnl.Visible = false;
            CurrentLocation.Visible = false;
            lblParking.Visible = false;
            lblMainText.Visible = true;
            lblBanks.Visible = false;
            Accessibilitylbl.Visible = false;
            lblFireExit.Visible = false;
            lblTextOutput.Visible = false;
            Helppnl.Visible = false;
            Searchpnl.Visible = false;
            Shoppingpnl.Visible = false;
            Foodpnl.Visible = false;
            Discountpnl.Visible = false;
        }

        private void HambrgMenuClose_Click(object sender, EventArgs e)
        {
            MoreOptionspnl.Visible = false;
        }

        private void LanguageChangebtn_Click(object sender, EventArgs e)
        {
            LanguagePanel.Visible = true;
            MainPanel.Visible = false;
        }
        //Zooming in and out
        private void Zoomin_Click(object sender, EventArgs e)
        {
            ShoppingMap.Size = new Size(491, 498);
            buttonBox.Visible = true;
        }

        private void Zoomout_Click(object sender, EventArgs e)
        {
            ShoppingMap.Size = new Size(377, 366);
        }
        //making the Text size bigger
        private void TextSizebtn_Click(object sender, EventArgs e)
        {
            PrivateFontCollection OpenSans = new PrivateFontCollection();
            PrivateFontCollection ProximaNova = new PrivateFontCollection();
            //Open sans
            OpenSans.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\static\OpenSans-Bold.ttf");
            lblSelect.Font = new Font(OpenSans.Families[0], 17, FontStyle.Bold);
            lblMainText.Font = new Font(OpenSans.Families[0], 17, FontStyle.Bold);

            //Proxima nova
            ProximaNova.AddFontFile(@"G:\My Drive\Unit 10\Assignment 2\Fonts\Proxima Nova Font.otf");
            Searchlbl.Font = new Font(ProximaNova.Families[0], 13);
            Parkinglbl.Font = new Font(ProximaNova.Families[0], 13);
            Banklbl.Font = new Font(ProximaNova.Families[0], 13);
            Shopslbl.Font = new Font(ProximaNova.Families[0], 13);
            Foodlbl.Font = new Font(ProximaNova.Families[0], 13);
            Discountlbl.Font = new Font(ProximaNova.Families[0], 13);
            Disabledlbl.Font = new Font(ProximaNova.Families[0], 12);
            Disabledlbl2.Font = new Font(ProximaNova.Families[0], 11);
            FireExitlbl.Font = new Font(ProximaNova.Families[0], 13);
            Helplbl.Font = new Font(ProximaNova.Families[0], 13);
            Textlbl.Font = new Font(ProximaNova.Families[0], 13);
            sizelbl.Location = new Point(81, 235);
            sizelbl.Font = new Font(ProximaNova.Families[0], 13);
            Changelbl.Font = new Font(ProximaNova.Families[0], 13);
            Languagelbl.Location = new Point(210,235);
            Languagelbl.Font = new Font(ProximaNova.Families[0], 13);
            TextTolbl.Font = new Font(ProximaNova.Families[0], 13);
            Speachlbl.Location = new Point(343, 235);
            Speachlbl.Font = new Font(ProximaNova.Families[0], 13);
        }
        //As the location of the text is always the same, some have to be hidden and shown when the user clicks on the relevant button.
        private void Parkingbtn_Click(object sender, EventArgs e)
        {
            CurrentLocation.Visible = true;
            CurrentLocation.Location = new Point(169, 160);
            lblMainText.Visible = false;
            lblParking.Visible = true;
            lblBanks.Visible = false;
            Accessibilitylbl.Visible = false;
            lblFireExit.Visible = false;
            lblTextOutput.Visible = false;
        }

        private void Bankbtn_Click(object sender, EventArgs e)
        {
            CurrentLocation.Visible = true;
            CurrentLocation.Location = new Point(347, 294);
            lblBanks.Visible = true;
            lblParking.Visible = false;
            lblMainText.Visible = false;
            Accessibilitylbl.Visible = false;
            lblFireExit.Visible = false;
            lblTextOutput.Visible = false;
        }

        private void Accessibilitybtn_Click(object sender, EventArgs e)
        {
            CurrentLocation.Visible = true;
            CurrentLocation.Location = new Point(132, 184);
            lblMainText.Visible = false;
            lblParking.Visible = false;
            lblBanks.Visible = false;
            Accessibilitylbl.Visible = true;
            lblFireExit.Visible = false;
            lblTextOutput.Visible = false;
        }

        private void Firebtn_Click(object sender, EventArgs e)
        {
            CurrentLocation.Visible = true;
            CurrentLocation.Location = new Point(25, 273);
            lblMainText.Visible = false;
            lblParking.Visible = false;
            lblFireExit.Visible = true;
            lblBanks.Visible = false;
            Accessibilitylbl.Visible = false;
            lblTextOutput.Visible = false;
            FireExit.Visible = true;
        }

        private void Location_Click(object sender, EventArgs e)
        {

        }

        private void TextToSpeachbtn_Click(object sender, EventArgs e)
        {
            voice.SelectVoiceByHints(VoiceGender.Male);
            CurrentLocation.Location = new Point(25, 273);
            lblMainText.Visible = false;
            lblParking.Visible = false;
            lblFireExit.Visible = false;
            lblBanks.Visible = false;
            Accessibilitylbl.Visible = false;
            lblTextOutput.Visible = true;
            voice.Speak(lblTextOutput.Text);
        }
        //Text to speech
        private void lblMainText_Click(object sender, EventArgs e)
        {
            voice.Speak(lblMainText.Text);
        }

        private void lblParking_Click(object sender, EventArgs e)
        {
            voice.Speak(lblParking.Text);
        }

        private void lblParking_Click_1(object sender, EventArgs e)
        {
            voice.Speak(Parkinglbl.Text);
        }

        private void lblBanks_Click(object sender, EventArgs e)
        {
            voice.Speak(lblBanks.Text);
        }

        private void Accessibilitylbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Accessibilitylbl.Text);
        }

        private void lblFireExit_Click(object sender, EventArgs e)
        {
            voice.Speak(lblFireExit.Text);
        }

        private void Textlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Textlbl.Text);
        }

        private void sizelbl_Click(object sender, EventArgs e)
        {
            voice.Speak(sizelbl.Text);
        }

        private void Changelbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Changelbl.Text);
        }

        private void Languagelbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Languagelbl.Text);
        }

        private void TextTolbl_Click(object sender, EventArgs e)
        {
            voice.Speak(TextTolbl.Text);
        }

        private void Speachlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Speachlbl.Text);
        }

        private void lblTextOutput_Click(object sender, EventArgs e)
        {

        }

        private void MoreOptionspnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Searchlbl.Text);
        }

        private void Parkinglbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Parkinglbl.Text);
        }

        private void Banklbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Banklbl.Text);
        }

        private void Shopslbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Shopslbl.Text);
        }

        private void Foodlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Foodlbl.Text);
        }

        private void Discountlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Discountlbl.Text);
        }

        private void Disabledlbl2_Click(object sender, EventArgs e)
        {
            voice.Speak(Disabledlbl2.Text);
        }

        private void FireExitlbl_Click(object sender, EventArgs e)
        {
            voice.Speak(FireExitlbl.Text);
        }

        private void Helplbl_Click(object sender, EventArgs e)
        {
            voice.Speak(Helplbl.Text);
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {
            voice.Speak(lblSelect.Text);
        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {
            voice.Speak(lblEnglish.Text);
        }

        private void lblGerman_Click(object sender, EventArgs e)
        {
            voice.Speak(lblGerman.Text);
        }

        private void lblDeutch_Click(object sender, EventArgs e)
        {
            voice.Speak(lblDeutch.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            voice.Speak(label3.Text);
        }

        private void lblErabic_Click(object sender, EventArgs e)
        {
            voice.Speak(lblErabic.Text);
        }

        private void lblPolish_Click(object sender, EventArgs e)
        {
            voice.Speak(lblPolish.Text);
        }

        private void lblPolski_Click(object sender, EventArgs e)
        {
            voice.Speak(lblPolski.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            voice.Speak(label1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            voice.Speak(label2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            voice.Speak(label4.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            voice.Speak(label5.Text);
        }

        private void HelpbtnClose_Click(object sender, EventArgs e)
        {
            Helppnl.Visible = false;
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            Helppnl.Visible = true;
        }
        //creating the search bar
        List<string> listcollection = new List<string>();
        private void Searchbar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Searchbar.Text) == false)
            {
                Searchlistbox.Items.Clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(Searchbar.Text))
                    {
                        Searchlistbox.Items.Add(str);
                    }
                }
            }
            else if (Searchbar.Text == "")
            {
                Searchlistbox.Items.Clear();
                foreach (string str in listcollection)
                {
                    Searchlistbox.Items.Add(str);
                }
            }
            //search results
            if (Searchbar.Text == "Parking")
            {
                CurrentLocation.Visible = true;
                CurrentLocation.Location = new Point(169, 160);
                lblMainText.Visible = false;
                lblParking.Visible = true;
                lblBanks.Visible = false;
                Accessibilitylbl.Visible = false;
                lblFireExit.Visible = false;
                lblTextOutput.Visible = false;
            }
            else if (Searchbar.Text == "Banks")
            {
                CurrentLocation.Visible = true;
                CurrentLocation.Location = new Point(347, 294);
                lblBanks.Visible = true;
                lblParking.Visible = false;
                lblMainText.Visible = false;
                Accessibilitylbl.Visible = false;
                lblFireExit.Visible = false;
                lblTextOutput.Visible = false;
            }
            else if (Searchbar.Text == "Disabled Facilities")
            {
                CurrentLocation.Visible = true;
                CurrentLocation.Location = new Point(132, 184);
                lblMainText.Visible = false;
                lblParking.Visible = false;
                lblBanks.Visible = false;
                Accessibilitylbl.Visible = true;
                lblFireExit.Visible = false;
                lblTextOutput.Visible = false;
            }
            else if (Searchbar.Text == "Fire exits")
            {
                CurrentLocation.Visible = true;
                CurrentLocation.Location = new Point(25, 273);
                lblMainText.Visible = false;
                lblParking.Visible = false;
                lblFireExit.Visible = true;
                lblBanks.Visible = false;
                Accessibilitylbl.Visible = false;
                lblTextOutput.Visible = false;
            }
            else if (Searchbar.Text == "Help")
            {
                Helppnl.Visible = true;
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Searchpnl.Visible = true;
        }

        private void SearchpnlClose_Click(object sender, EventArgs e)
        {
            Searchpnl.Visible = false;
        }
        //Giving the same location using combo boxes depending on the language
        private void CategoryCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCombBox.Text == "Fashion" || CategoryCombBox.Text == "Moda" || CategoryCombBox.Text == "موضة" || CategoryCombBox.Text == "Mode")
            {
                FashionComboBox.Visible = true;
                GroceriesComboBox.Visible = false;
                ElectronicsComboBox.Visible = false;
            }
            else if (CategoryCombBox.Text == "Groceries" || CategoryCombBox.Text == "البقالة" || CategoryCombBox.Text == "Artykuły spożywcze" || CategoryCombBox.Text == "Lebensmittel" || CategoryCombBox.Text == "Épiceries" || CategoryCombBox.Text == "Comestibles")
            {
                GroceriesComboBox.Visible = true;
                FashionComboBox.Visible = false;
                ElectronicsComboBox.Visible = false;
            }
            else if (CategoryCombBox.Text == "Electronics" || CategoryCombBox.Text == "إلكترونيات" || CategoryCombBox.Text == "Elektronika" || CategoryCombBox.Text == "Elektronik" || CategoryCombBox.Text == "Électronique" || CategoryCombBox.Text == "Electrónica")
            {
                ElectronicsComboBox.Visible = true;
                GroceriesComboBox.Visible = false;
                FashionComboBox.Visible = false;
            }
        }

        private void Shoppingpnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Shopsbtnclose_Click(object sender, EventArgs e)
        {
            Shoppingpnl.Visible = false;
        }

        private void FashionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FashionComboBox.Text == "Exit Shoes")
            {
                CurrentLocation.Location = new Point(175, 310);
                CurrentLocation.Visible = true;
            }
            else if (FashionComboBox.Text == "Style and Beauty")
            {
                CurrentLocation.Location = new Point(233,311);
                CurrentLocation.Visible = true;
            }
            else if (FashionComboBox.Text == "Peacocks")
            {
                CurrentLocation.Location = new Point(300, 304);
                CurrentLocation.Visible = true;
            }
            else if (FashionComboBox.Text == "Belson & Shoes")
            {
                CurrentLocation.Location = new Point(191, 338);
                CurrentLocation.Visible = true;
            }
            else if (FashionComboBox.Text == "Shoe Zone")
            {
                CurrentLocation.Location = new Point(143, 362);
                CurrentLocation.Visible = true;
            }
        }

        private void ShoppingMap_Click(object sender, EventArgs e)
        {

        }

        private void GroceriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroceriesComboBox.Text == "Poundland")
            {
                CurrentLocation.Location = new Point(176, 240);
                CurrentLocation.Visible = true;
            }
            else if (GroceriesComboBox.Text == "Savers")
            {
                CurrentLocation.Location = new Point(213, 311);
                CurrentLocation.Visible = true;
            }
            else if (GroceriesComboBox.Text == "Iceland")
            {
                CurrentLocation.Location = new Point(271, 311);
                CurrentLocation.Visible = true;
            }
            else if (GroceriesComboBox.Text == "QD Stores")
            {
                CurrentLocation.Location = new Point(244, 327);
                CurrentLocation.Visible = true;
            }
            else if (GroceriesComboBox.Text == "Farm Foods")
            {
                CurrentLocation.Location = new Point(72,284);
                CurrentLocation.Visible = true;
            }
        }

        private void ElectronicsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ElectronicsComboBox.Text == "All Things Mobile")
            {
                CurrentLocation.Location = new Point(132, 372);
                CurrentLocation.Visible = true;
            }
            else if (ElectronicsComboBox.Text == "CEX")
            {
                CurrentLocation.Location = new Point(135, 323);
                CurrentLocation.Visible = true;
            }
            else if (ElectronicsComboBox.Text == "Apple")
            {
                CurrentLocation.Location = new Point(31,327);
                CurrentLocation.Visible = true;
            }
        }

        private void FoodbtnClose_Click(object sender, EventArgs e)
        {
            Foodpnl.Visible = false;
        }

        private void FoodCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FoodCombBox.Text == "Wimpy")
            {
                CurrentLocation.Location = new Point(148, 250);
                CurrentLocation.Visible = true;
            }
            else if (FoodCombBox.Text == "Burger King")
            {
                CurrentLocation.Location = new Point(152, 417);
                CurrentLocation.Visible = true;
            }
            else if (FoodCombBox.Text == "Costa")
            {
                CurrentLocation.Location = new Point(143, 444);
                CurrentLocation.Visible = true;
            }
            else if (FoodCombBox.Text == "Centre Cafe")
            {
                CurrentLocation.Location = new Point(35, 311);
                CurrentLocation.Visible = true;
            }
        }

        private void Foodbtn_Click(object sender, EventArgs e)
        {
            Foodpnl.Visible = true;
            Discountpnl.Visible = false;
            Shoppingpnl.Visible = false;
        }

        private void Discountbtn_Click(object sender, EventArgs e)
        {
            Foodpnl.Visible = false;
            Discountpnl.Visible = true;
            Shoppingpnl.Visible = false;
        }

        private void DiscountbtnClose_Click(object sender, EventArgs e)
        {
            Discountpnl.Visible = false;
        }

        private void DiscountCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiscountCombBox.Text == "20% Off Phone Accessories - All Things Mobile")
            {
                CurrentLocation.Location = new Point(132, 372);
                CurrentLocation.Visible = true;
            }
            else if (DiscountCombBox.Text == "Free Airpods with purchase of IPhone - Apple")
            {
                CurrentLocation.Location = new Point(31, 327);
                CurrentLocation.Visible = true;
            }
            else if (DiscountCombBox.Text == "10% Off Any Furniture - QD Stores")
            {
                CurrentLocation.Location = new Point(244, 327);
                CurrentLocation.Visible = true;
            }
        }

        private void Accessibilitypnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {
            voice.Speak(lblInstructions.Text);
        }

        private void lblInstructions2_Click(object sender, EventArgs e)
        {
            voice.Speak(lblInstructions2.Text);
        }

        private void lblInstructions3_Click(object sender, EventArgs e)
        {
            voice.Speak(lblInstructions3.Text);
        }
    }
}