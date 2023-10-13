Assignment 1
Started assignment couple times becaues it crashes
2023-10-10
1005
Strated the assignment with the help of microsoft
Create a new Repositry named JarCreations
And adding all the neccessary files in it
adding new controller for codes
then repalce the content with provided code 
change the code from Mvc Movie to Jar Creations
And testing the default action
1015
Jump to next section 
chnging the host address and the  a new method shown
After that strated work with Hello Rick method for runtime and it works
1027
After completing all of these
Starde to add new view Named Jar creationscontroller
I add it into a view folder
And it works
Now it change the Properties in layout with my project name
1110
Entering to work with model
Create a class name Jar 
Update with the following code that is microsoft
Add NuGet packages
We solve that proble to install packages 
by insta its programe
Microsoft.EntityFrameworkCore.SqlServer
Now i  crate database context class
Called JarCreationsContext
And change the content in it
1137
Add the code in Startup.ConfigureServices:
1141
This is a time to Add Scaffold 
I made a mistake in it 
i didnt add all the properties first and i scaffold then i have to put all properties one by one 
Properties mean Title Capacity and other like these
Adding scaffold but it didnt work i dont know why but whne i tried it two times it works
1203
In the PMC i put the following commands'
Add-Migration InitialCreate
Update-Database

And it creats Migrations Then  i examine all the proces that is provided 
1212
Now its a time to work with Database
Following the every step Provided by slides
and examine every situation
1245
Now I worked with Seed Data
Copy the first code and then i add my own seed data for my project
Then  i add the seed initilizer
to initilize that code we have to Replace the content of Program.cs
Then ii test the app and it runs perfectly 
All the seed data showes on desktop
1503
Now its time to Add new system in all types like Edit,Create And Delete
i follow the instructions that provide and it show some variable problems 
Beacuse of Names And the n it works perfectly

1635
Now i step up to the search bar to aad it in my project
Firstly I Update the Index method
With following code
public async Task<IActionResult> Index(string searchString)
{
    var movies = from m in _context.Movie
                 select m;

    if (!String.IsNullOrEmpty(searchString))
    {
        movies = movies.Where(s => s.Title.Contains(searchString));
    }

    return View(await movies.ToListAsync());
}
Thentest it to put name in url 
and work perfect
So this is not a proper way to search item then  add aseach bar by adding code in
Index add in follows jar name
Noe it stime to change this feature to Search by genre
I add new Class named JartypeViewModel
And update the data
Replace the Index method in JarsController.cs with the provided code
Then i Update Index.cshtml which is in Views/Jars
1718
Now i adding a new propeties called Rating
Then i build the app aand Bind it 
Now i adding rating feild in Index and other fileds
After adding to in every cs file i run foloowing commands in PMC
Add-Migration Rating
Update-Database
2106
I worked with Add validation rules to the Jar Model
public class Jar
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required] // this is use for NAme 
   

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    Tis is use for date 


    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    This is use to price 
    

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    This is use to type
   

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
     this used for rating
   
}
every Regular expression has its own Propertie
2230 
I stoped work for today see you tommoero :)


Have good Morning
Its time 2023-10-13
Morning In college 
Last days i worked with evry thing thing and now its time to work with css and htl 
I added new page called about us for my project
In it I added about my company
And give Breif discription 
In home page i add Contact and some photos of art and  the following code
    <style>
        body {
           background-color:lightgray;
        }
        p {
            color: black; 
             text-align: center; 
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', "sans-serif"
        }
        h1 {
            background-color: ghostwhite;
                border-radius: 10px;
        }
    </style>
 I add some of color in every page 
 As my Mind ilke to make website simple 
 Beacuse i dont like Warm things
 Thats why i didnt add any Images
 If someone want to add image intheir Project so They simply add
 background-image
 background-color this is for color 
 I mae some changes and playing with it 
 With that i complete my project
 at 1457
 2023-10-13
