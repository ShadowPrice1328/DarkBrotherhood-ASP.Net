﻿namespace HelloASP.Models
{
	public class DonationModel
	{
        public void SaveDonation(string gift)
        {
            string filePath = "AppData/donations.txt";
            using (StreamWriter writer = new(filePath, true))
            {
                writer.WriteLine(gift);
            }
        }
    }
}
