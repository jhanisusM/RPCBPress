using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPClassicalBaptistPress.Pages
{
    public class PublicationsModel : PageModel
    {
        public class Publications
        {
            public string PurchaseBtn { get; set; }
            public string Device { get; set; }
            public string Title { get; set; }
            public string DescriptionParagraph { get; set; }
            public string Author { get; set; }
            public string EmbeddedHTMLPublicationImg { get; set; }
        }
         
        
        public static List<Publications> GetPublicationInfo()
        {
            string PolemicTheology = System.IO.File.ReadAllText(@"C:\Users\User\source\repos\RPCBPress\Pages\PolemicTheology.txt");
            List<Publications> output = new List<Publications>
            {
                new Publications
                {
                    PurchaseBtn="<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em' id = 'checkout-button-sku_FmzE9du2jC7IGE' role = 'link' type = 'button' >Click to Purchase(Secure Site)</button>",
                    Device="Print",
                    Title=" The Church of Jesus Christ: 28 Truths Every Christian Ought to Learn",
                    DescriptionParagraph="<p class='indentation'>An exhaustive guide to the New Testament's teaching into the nature of the Church of Jesus Christ.</p>",
                    Author="Dr. John S. Waldrip (Author), Th.D",
                    EmbeddedHTMLPublicationImg="<img src='./images/28.JPG' alt='portrait' class='img-fluid thumbnails '>",
                },
                new Publications
                {
                    PurchaseBtn="<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em' id ='checkout-button-sku_G96NoRLr9JV2zC' role = 'link' >Click to Purchase(Secure Site)</button>",
                    Device="Print",
                    Title="A Basic <em>Leader's</em> Manual for the Study of Ecclesiology",
                    DescriptionParagraph="<p class='indentation'> An exhaustive <em>Leader's</em> guide to the New Testament's teaching into the nature of the Church of Jesus Christ.</p>",
                    Author="Stanford E. Murrell, Ph.D.",
                    EmbeddedHTMLPublicationImg=" <img src='./images/LeaderGuide.png' alt='portrait' class='img-fluid thumbnails'>",
                },
                new Publications
                {
                    PurchaseBtn = "<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em' id ='checkout-button-sku_G96fzawHrMNbcC' role = 'link'> Click to Purchase(Secure Site)</button>",
                    Device = "Print",
                    Title = "A Basic <em>Learner's</em> Manual for the Study of Ecclesiology",
                    DescriptionParagraph = "<p class='indentation'> An exhaustive <em>Learner's</em> guide to the New Testament's teaching into the nature of the Church of Jesus Christ.</p>",
                    Author = "Stanford E. Murrell, Ph.D.",
                    EmbeddedHTMLPublicationImg = " <img src='./images/LearnerGuide.png' alt='portrait' class='img-fluid thumbnails'>",
                },
                new Publications
                {
                    PurchaseBtn = "<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em'        onclick='window.location.href='https://www.amazon.com/Suffer-Children-tragic-legacies-Bushnell-ebook/dp/B072FHM89F'       target='blank'> Click to Purchase</button>",
                    Device = "Kindle Edition",
                    Title = " Suffer The Children: (The tragic legacies of Finney & Bushnell)",
                    DescriptionParagraph = "<p class='indentation'> No one lives in isolation. Everyone functions in an environment that is formed by what has occurred in the past. Have you considered how very differently child evangelism differs from past eras? Are you aware of the influence of men now forgotten on how the Gospel is presented to children? In this book you will be introduced to the influences of two men you likely have never heard of before. Just as importantly, it is likely that one or both of these influential men is unknown to your pastor. This book begins to set the record straight so parents and pastors will not inadvertently be more barriers than escorts of children coming to the Savior.</p>",
                    Author = "Dr. John S. Waldrip (Author)",
                    EmbeddedHTMLPublicationImg = "<img src='https://images-na.ssl-images-amazon.com/images/I/51zMJt%2BS1wL.jpg' alt='portrait' class='img-fluid thumbnails'>",
                },
                new Publications
                {
                    PurchaseBtn = "<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em' id='checkout-button-sku_G95Ms5hhIOHwyh' role='link' type='button'> Click to Purchase (Secure Site)</button>",
                    Device = "Kindle Edition",
                    Title = "The Blight of Islam (Revised)",
                    DescriptionParagraph = "<p class='indentation'>A well-reasoned comparison and contrast of the two largest religions in the world, the only two religions claiming their holy books were given by revelation, and the only two religions that claim to be for all humanity. The sources used are those of the two religious faiths to gain insight into the founders of the two religions, Jesus and Mohammed.</p>",
                    Author = "Dr. John S. Waldrip (Author), Senator James M. Inhofe (Foreword)",
                    EmbeddedHTMLPublicationImg = " <img src='https://m.media-amazon.com/images/I/51yzWq3Z+6L.jpg' alt='portrait' class='img-fluid thumbnails'>",
                },
                new Publications
                {
                    PurchaseBtn ="<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em' onclick='window.location.href='./assets/polemicTheology.pdf' target='blank'> CLICK TO READ </button>",
                    Device = "Online",
                    Title = " Polemic Theology: How To Deal With Those Who Differ From Us",
                    DescriptionParagraph = PolemicTheology,
                    Author = "Roger Nicole (Author)",
                    EmbeddedHTMLPublicationImg = "<img src='./images/bible.jpg' alt='bible' class='img-fluid thumbnails' />",
                },
                new Publications
                {
                    PurchaseBtn = "<button style='background-color:#6772E5;color:#FFF;padding:8px 12px;border:0;border-radius:4px;font-size:1em'           onclick='window.location.href='./assets/Halloween_A_Result_of_Religious_Apostasy.pdf' formtarget='_blank'> Click to Read </button>",
                    Device = "Online",
                    Title = "Halloween, A Result of Religious Apostasy",
                    DescriptionParagraph = "<p class='indentation'> This time of year Baptist churches face the dilemma of a rapidly approaching Halloween season and all of its attendant issues. Those I serve as pastor have been thoroughly instructed over the years and buy into our ministry's annual Christian Alternative to Halloween. Perhaps you do something along that line, as well. But what of those added to the church since last Halloween? How do you address the issue for new families without rehashing the whole subject all over again when most in the congregation already convinced of what's right? </ p >",
                    Author = "Dr. John S. Waldrip (Author)",
                    EmbeddedHTMLPublicationImg = "<img src='./images/halloween.PNG' alt='portrait' class='img-fluid thumbnails'>",
                },
            };
            return output;
        }

        public void OnGet()
        {
        } 
        
    }
}
