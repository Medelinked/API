using System;
using System.Collections.Generic;

namespace Medelinked.Core.Response
{
	public class User
	{
		public User ()
		{
		}

		public string ID { get; set; }
		public string Name { get; set; }
		public string DateOfBirth { get; set; }
		public string NHSNumber { get; set; }
		public string RegisteredGP { get; set; }
		public string Nationality { get; set; }
		public string Photo { get; set; }
		public string GPAddress { get; set; }
		public string GPPhone { get; set; }
		public string Gender { get; set; }
		public string BloodGroup { get; set; }
		public string ZaptagID { get; set; }
		public string OptOutOfEmergencyRecord { get; set; }
		public string Message { get; set; }
		public string LocalProfileImage { get; set; }
		public string TwoFactorAuthenticationEnabled { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string SmokingStatus { get; set; }

		//Add insurance details
        public string PassportNumber { get; set; }
		public string HealthInsurer { get; set; }
		public string HealthInsurancePolicyNumber { get; set; }
		public string HealthInsurerPhone { get; set; }
		public string TravelInsurer { get; set; }
		public string TravelInsurancePolicyNumber { get; set; }
		public string TravelInsurerPhone { get; set; }

		//Social Options
		public string BloodDonor { get; set; }
		public string BloodDonorNumber { get; set; }
		public string LastDonated { get; set; }
		public string OrganDonor { get; set; }

		//Drug Trial Options
		public string DrugTrialTakingPart { get; set; }
		public string DrugTrialStudyName { get; set; }
		public string DrugTrialStarted { get; set; }
		public string DrugTrialCompleted { get; set; }
		public string DrugTrialDoctor { get; set; }
		public string DrugTrialDoctorPhone { get; set; }

        public List<string> Tags { get; set; }

	}
}

