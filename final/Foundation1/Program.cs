using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Josh Groban - February Song [Live]", "Josh Groban", 309);
        video1.SetListAddComment("@ChastarWoo", "THIS SONG DESERVES AN AWARD");
        video1.SetListAddComment("@Jfox_2007", "This song really deserves to be in No.1 Spot on Spotify");
        video1.SetListAddComment("@conipender4272", "Beautiful ! Reminds of the romance of years gone by!");

        Video video2 = new Video("Alex Sampson - Pretty Baby (Official Music Video)", "Alex Sampson", 206);
        video2.SetListAddComment("@ChastarWoo", "THIS SONG DESERVES AN AWARD");
        video2.SetListAddComment("@Jfox_2007", "This song really deserves to be in No.1 Spot on Spotify");
        video2.SetListAddComment("@conipender4272", "Beautiful ! Reminds of the romance of years gone by!");

        Video video3 = new Video("Dieter F. Uchtdorf | Octubre 2024 Conferencia General", "Conferencia General de La Iglesia de Jesucristo", 871);
        video3.SetListAddComment("@JoséGuillermoHinojosaPatiño", "Es un deleite escucharlo, totalmente inspirado");
        video3.SetListAddComment("@taricanada", "a mí tb me gustan mucho sus discursos");
        video3.SetListAddComment("@paquitagarciamartinez1940", "Me gustan tus discursos");
        video3.SetListAddComment("@JoséGuillermoHinojosaPatiño", "Que Dios permita tenerlo entre nosotros por muchísimos años");

        Video video4 = new Video("He Lifts Weights For A Living And Needed His Shoulder Worked On", "Dr. Tyler Bigenho DC", 713);
        video4.SetListAddComment("@yvonnebb961", "adjusting him is your workout for the day Tyler!");
        video4.SetListAddComment("@tomwyant9297", "The love smack at 8:46!");
        video4.SetListAddComment("@SylviaSpanlang-fp2px", "As always a pleasure to see you Dr. Tyler! Happy day for you!");
        video4.SetListAddComment("@mercedesdriver5707", "I love watching your videos. I wished I live close so I could get adjusted. My back would freak you out");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        Console.Clear();
        Console.WriteLine("Press enter to continue!!");
        Console.ReadLine();
        Console.Clear();
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
