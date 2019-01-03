using System;

namespace Hospital
{
    public class Patient
    {
        public Patient()
        {
            IsNew = true;
            _bloodSugar = 5.0f;
        }

        private float _bloodSugar;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int HeartBeatRate { get; set; }
        public bool IsNew { get; set; }

        public float BloodSugar
        {
            get { return _bloodSugar; }
            set { _bloodSugar = value; }
        }

        public void HaveDinner()
        {
            var random = new Random();
            _bloodSugar += (float)random.Next(1, 1000) / 1000;  //1000
        }


        public void IncreaseHeartBeatRate()
        {
            HeartBeatRate = CalculateHeartBeatRate() + 2;
        }

        private int CalculateHeartBeatRate()
        {
            var random = new Random();
            return random.Next(1, 100);
        }

    }
}
