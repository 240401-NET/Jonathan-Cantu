

namespace projectZero;

class NationalPark{
    public string Name{get;set;}
    public string InState{get;set;}
    public string Summary{get;set;}

    public NationalPark(){}

    public NationalPark(string Name,string InState,string Summary){
        this.Name = Name;
        this.InState= InState;
        this.Summary=Summary;
    }
}