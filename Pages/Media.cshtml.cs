using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPClassicalBaptistPress.Pages
{
    public class Media : PageModel
    {
        public class MediaFiles
        {
            public string Title { get; set; }
            public string DescriptionParagraph { get; set; }
            public string Author { get; set; }
            public string SourcePath { get; set; }
            public string EmbeddedHTMLMediaFile { get; set; }
        }
        public static List<MediaFiles> GetMediaFiles()
        {
            List<MediaFiles> output = new List<MediaFiles>
            {
                new MediaFiles
                {
                    Title="Three Creations, Two Lives",
                    Author="Joe Doyel",
                    DescriptionParagraph="Pastor Joe Doyle explains the three creations of God.",
                    EmbeddedHTMLMediaFile=$@"<audio controls='controls' preload='auto'><source src='./assets/threeCreations.mp3' typeof='audio/ogg'></audio>"
                },
                new MediaFiles
                {
                  Title="Doing Apologetics in an Anti-Apologetics Age",
                  Author="Dr. Voddie Baucham",
                  DescriptionParagraph="Dr. Voddie Baucham, Dean at African Christian University's Seminary in Lusaka, Zambia discussesapologetics and its importance in everyday life.",
                  EmbeddedHTMLMediaFile=@"<iframe width='320' height='180' src='https://www.youtube.com/embed/t91z67hvFvw' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>",
                },
                new MediaFiles
                {
                  Title="Why you can believe the Bible",
                  Author="Voddie Baucham",
                  DescriptionParagraph="Voddie Baucham is a husband, father, pastor, author, professor, conference speaker and church planter. He serves as Pastor of Preaching at Grace Family Baptist Church in Spring, Texas.",
                  EmbeddedHTMLMediaFile=@"<iframe width='320' height='180' src='https://www.youtube.com/embed/G1XJ7DeR5fc' title='YouTube video player' frameborder='0' allow = 'accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>",
                },
                new MediaFiles
                {
                    Title="Why I believe the Bible",
                    Author="Dr. Voddie Baucham",
                    DescriptionParagraph=@"The Bible is a reliable collection of historical documents written down by eyewitnesses during the
                    lifetime of other eyewitnesses. They report to us supernatural events that took place in
                    fulfillment of specific prophesies, and claim that their writings are divine rather than human in
                    origin",
                    EmbeddedHTMLMediaFile=@"<iframe width='320' height='180' src='https://www.youtube.com/embed/15EoR6O-rUA' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
                },
                new MediaFiles
                {
                    Title="Baptism Is A Church’s Act",
                    Author="Bobby Jamieson",
                    DescriptionParagraph=@"What would you do if you were wading in a swimming pool and a friend came up behind you and
                    dunked you under the water? You could simply forgive your friend—a solidly Christian move.
                    You could retaliate in kind. You could even escalate the aquatic conflict, waiting until
                    your friend got out and dried off before shoving him or her back into the pool. So, which
                    will it be?
                    <br />
                    <div class='d-flex justify-content-start'>
                    <a href='https://www.9marks.org/article/baptism-is-a-churchs-act/?utm_source=eml-article&utm_medium=eml-article&utm_campaign=eml-article&mc_cid=d551c3ff11&mc_eid=4b26d90fc2' class='btn btn-secondary'>Read More</a>",
                    EmbeddedHTMLMediaFile=@"<img src='./images/baptism.jpg' alt='baptism' class='img-fluid' style='width:300px'>",
                },
            };
            return output;
        }

        public void OnGet()
        {

        }
    }
}
