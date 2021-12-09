using SolarEclipse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarEclipse.Data
{
	public class DbInitializer
	{
		public static void Initialize(SolarEclipseContext context)
		{
			if (context.VolunteerPositions.Any())
			{
				return;
			}

			var contacts = new Contact[]
			{
				new Contact
				{
					Name = "Jo Quill",
					Email = "JQ@gmail.com",
					Message = "When will the playlist be made for the public to view?"
				},
				new Contact
				{
					Name = "Jo Quill",
					Email = "JQ@gmail.com",
					Message = "Also, why is there so much lorem ipsum?"
				},
				new Contact
				{
					Name = "Ganan Granan",
					Email = "GG@AOL.com",
					Message = "I can't wait for the party! Can anyone come? I have a few friends wanting to."
				},
				new Contact
				{
					Name = "Iss Khonononon",
					Email = "IK@outlook.com",
					Message = "Hey I want to volunteer in a way that isn't the available positions."
				},
				new Contact
				{
					Name = "Ta Hwoop",
					Email = "THAT@yahoo.com",
					Message = "The website looks good, but I really want to buy Merchandise now.... " +
					"When will it be available?"
				}
			};

			context.AddRange(contacts);

			var musicsubs = new MusicSub[]
			{
				new MusicSub
				{
					Email = "JQ@gmail.com",
					Artist = "TayTay",
					Song = "ShakeOffTheSun",
					MusicLink = "https://open.spotify.com/track/4uLU6hMCjMI75M1A2tKUQC"
				},
				new MusicSub
				{
					Email = "GGG@AOL.com",
					Artist = "Artist23",
					Song = "The Eclipse Is Now",
				},
				new MusicSub
				{
					Email = "IIIK@outlook.com",
					Artist = "Bonnie Tyler",
					Song = "Total Eclipse of the Heart",
					MusicLink = "https://open.spotify.com/track/7wuJGgpTNzbUyn26IOY6rj"
				},
				new MusicSub
				{
					Email = "THHAT@yahoo.com",
					Artist = "Pink Floyd",
					Song = "Eclipse",
					MusicLink = "https://pranx.com/fake-virus/"
				}
			};

			context.AddRange(musicsubs);

			var glass1 = new VolunteerPosition
			{
				Position = "Glasses Table1",
				TimeStart = DateTime.Parse("2024-4-8T10:00:00.0000000-06:00"),
				PositionsFilled = "0/3"
			};
			var glass2 = new VolunteerPosition {
				Position = "Glasses Table2",
				TimeStart = DateTime.Parse("2024-4-8T10:30:00.0000000-06:00"),
				PositionsFilled = "2/3"
			};
			var merch1 = new VolunteerPosition {
				Position = "Merchandise Table1",
				TimeStart = DateTime.Parse("2024-4-8T10:00:00.0000000-06:00"),
				PositionsFilled = "1/2"
			};
			var merch2 = new VolunteerPosition {
				Position = "Merchandise Table2",
				TimeStart = DateTime.Parse("2024-4-8T11:00:00.0000000-06:00"),
				PositionsFilled = "0/2"
			};

			var volunteers = new Volunteer[]
			{
				new Volunteer
				{
					FirstName = "Jo",
					LastName = "Quill",
					Email = "JQ@gmail.com",
					Position = glass2
				},
				new Volunteer
				{
					FirstName = "Ta",
					LastName = "Hwoop",
					Email = "THAT@yahoo.com",
					Position = glass1
				},
				new Volunteer
				{
					FirstName = "Isss",
					LastName = "Konoh",
					Email = "IK@outlook.com",
					Position = merch2
				},
				new Volunteer
				{
					FirstName = "Ganan",
					LastName = "Granan",
					Email = "GG@AOL.com",
					Position = merch1
				}
			};

			context.AddRange(volunteers);
			context.SaveChanges();
		}
	}
}
