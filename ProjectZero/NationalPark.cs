

namespace projectZero;

class NationalPark{
    public string? Name{get;set;}
    public string? InState{get;set;}
    public string? Summary{get;set;}
    public bool VisitedPark{get;set;}
    public bool BucketListPark{get;set;}


    public NationalPark(){}

    public NationalPark(string Name,string InState,string Summary,bool VisitedPark, bool BucketListPark){
        this.Name = Name;
        this.InState= InState;
        this.Summary=Summary;
        this.VisitedPark=VisitedPark;
        this.BucketListPark=BucketListPark;
    }

 
 //public static string HaveVisited(){}
 
 // takin data and converting it to easily readible console text
public  string ToStringDisplayConverter()
    {
        string vispark= "";
        if (VisitedPark==true){
            vispark= "I've been to this park!!!";
        } else {
            vispark= " ";
        }

        string bukpark = "";
        if (BucketListPark==true){
            bukpark= "This Park is on my Bucket List!";
        } else {
            bukpark= " ";
        }

        return "*******************************************" + "\n" +
                "Name: " + Name + "   InState: " + InState +  
                "\nSummary: "+
                "\n" + Summary +
                "\n"
                + "\nSpecial notes: "
                + "\n* " + vispark + "\n*"+ bukpark
                + "\n";
    }




 
 public override string ToString()
    {
        string vispark= "";
        if (VisitedPark==true){
            vispark= "I've been to this park!!!";
        } else {
            vispark= "I have not been to this park";
        }

        string bukpark = "";
        if (BucketListPark==true){
            bukpark= "This Park is on my Bucket List!";
        } else {
            bukpark= " ";
        }

        return "Name: " + Name + "   InState: " + InState + "\nSummary " + Summary
        + "\nVisit Status = " + vispark + "\nBucketListPark"+ BucketListPark;
    }

}