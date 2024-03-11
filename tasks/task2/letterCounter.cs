public class Counter{
    public static void Main(){
        
        var dc= Count("this is letter");
        String valuePair= String.Join(",",dc.Select(kvp=>$"{kvp.Key}: {kvp.Value}"));
        Console.WriteLine(valuePair);
    }

    public static Dictionary <char,int> Count(String Word){
        Dictionary<char,int> newDict=new Dictionary<char,int>();
        
        foreach(char ch in Word){
            Console.WriteLine(ch);
            if (newDict.ContainsKey(ch)){
                newDict[ch]+=1;
            }else{
                newDict.Add(ch,1);
            }
        }
        return newDict;
    }
}
