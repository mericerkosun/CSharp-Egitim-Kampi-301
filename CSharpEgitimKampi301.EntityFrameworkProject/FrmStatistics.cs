using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EntityFrameworkProject
{
    public partial class FrmStatistics : Form
    {
        
        public FrmStatistics()
        {
            InitializeComponent();
        }

        CSharpEgitimKampiEntityFrameworkTravelDBEntities db = new CSharpEgitimKampiEntityFrameworkTravelDBEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblTotalCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();

            var avgCapacity = db.Location.Average(x => x.Capacity);
            lblAvgCapacity.Text = Convert.ToString(String.Format("{0:0.00}", avgCapacity));

            var avgTourPrice = db.Location.Average(x => x.Price);
            lblAvgTourPrice.Text = Convert.ToString(String.Format("{0:0.00}", avgTourPrice)) + " ₺";

            int latestCountryId = db.Location.Max(x => x.LocationId);
            lblLatestCountry.Text = db.Location.Where(x => x.LocationId == latestCountryId).Select(y => y.Country).FirstOrDefault();

            lblKapadokya.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romaGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x=> x.GuideId == romaGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            var highestCapacity = db.Location.Max(x => x.Capacity);
            lblHighestCapacity.Text = db.Location.Where(x => x.Capacity == highestCapacity).Select(y => y.City).FirstOrDefault();

            var highestPrice = db.Location.Max(x => x.Price);
            lblHighestPrice.Text = db.Location.Where(x => x.Price == highestPrice).Select(y => y.City).FirstOrDefault();

            var guideIdAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId ==guideIdAysegulCinar).Count().ToString();
        }

        private void lblTotalCapacity_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
