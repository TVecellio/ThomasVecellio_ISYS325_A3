using System.Windows.Forms;

namespace ThomasVecellio_ISYS325_A3
{
    public partial class Assignment3Form : Form
    {
        public Assignment3Form()
        {
            InitializeComponent();
            InitializeDeck();
            currentCards[0] = GetUniqueRandomCard();
            card1PictureBox.Image = cardImageList.Images[currentCards[0]];
            currentCards[1] = GetUniqueRandomCard();
            card2PictureBox.Image = cardImageList.Images[currentCards[1]];
            currentCards[2] = GetUniqueRandomCard();
            card3PictureBox.Image = cardImageList.Images[currentCards[2]];
            currentCards[3] = GetUniqueRandomCard();
            card4PictureBox.Image = cardImageList.Images[currentCards[3]];
            currentCards[4] = GetUniqueRandomCard();
            card5PictureBox.Image = cardImageList.Images[currentCards[4]];
        }
        List<int> deckList = new List<int>();
        int[] currentCards = new int[5];
        Random random = new Random();
        private void InitializeDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                deckList.Add(i);
            }
        }
        private void dealBtn_Click(object sender, EventArgs e)
        {
            if (!keep1CheckBox.Checked)
            {
                currentCards[0] = GetUniqueRandomCard();
                card1PictureBox.Image = cardImageList.Images[currentCards[0]];
            }

            
            if (!keep2CheckBox.Checked)
            {
                currentCards[1] = GetUniqueRandomCard();
                card2PictureBox.Image = cardImageList.Images[currentCards[1]];
            }


            if (!keep3CheckBox.Checked)
            {
                currentCards[2] = GetUniqueRandomCard();
                card3PictureBox.Image = cardImageList.Images[currentCards[2]];
            }


            if (!keep4CheckBox.Checked)
            {
                currentCards[3] = GetUniqueRandomCard();
                card4PictureBox.Image = cardImageList.Images[currentCards[3]];
            }

            
            if (!keep5CheckBox.Checked)
            {
                currentCards[4] = GetUniqueRandomCard();
                card5PictureBox.Image = cardImageList.Images[currentCards[4]];
            }
        }



        private int GetUniqueRandomCard()
        {
            int card;
            do
            {
                card = random.Next(52);
            }
            while (currentCards.Contains(card)); 

            return card;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;


                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (int card in currentCards)
                    {
                        writer.WriteLine(card);
                    }
                }

                MessageBox.Show("Hand saved successfully!");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < currentCards.Length; i++)
                {
                    currentCards[i] = -1;
                }

                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < lines.Length && i < currentCards.Length; i++)
                {
                    if (int.TryParse(lines[i], out int cardValue))
                    {
                        currentCards[i] = cardValue;
                    }
                }

                UpdateHandDisplay();
            }
        }

        private void UpdateHandDisplay()
        {
            if (currentCards[0] != -1 && currentCards[0] < cardImageList.Images.Count)
            {
                card1PictureBox.Image = cardImageList.Images[currentCards[0]];
            }
            else
            {
                card1PictureBox.Image = null;
            }

            if (currentCards[1] != -1 && currentCards[1] < cardImageList.Images.Count)
            {
                card2PictureBox.Image = cardImageList.Images[currentCards[1]];
            }
            else
            {
                card2PictureBox.Image = null;
            }

            if (currentCards[2] != -1 && currentCards[2] < cardImageList.Images.Count)
            {
                card3PictureBox.Image = cardImageList.Images[currentCards[2]];
            }
            else
            {
                card3PictureBox.Image = null;
            }

            if (currentCards[3] != -1 && currentCards[3] < cardImageList.Images.Count)
            {
                card4PictureBox.Image = cardImageList.Images[currentCards[3]];
            }
            else
            {
                card4PictureBox.Image = null;
            }

            if (currentCards[4] != -1 && currentCards[4] < cardImageList.Images.Count)
            {
                card5PictureBox.Image = cardImageList.Images[currentCards[4]];
            }
            else
            {
                card5PictureBox.Image = null;
            }
        }
    }
}
