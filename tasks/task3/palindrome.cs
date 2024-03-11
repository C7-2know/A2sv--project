
public class CheckPalindrome
{
    public static bool isPalindrome(String word){
        int left=0;
        int right=word.Length-1;
        while(left<right){
            int leftAsci=Convert.ToInt32(word[left]);
            int rightAsci=Convert.ToInt32(word[right]);
            if (leftAsci>122 || leftAsci<97)
            {
                left++ ;
            }
            else if (rightAsci<97 || rightAsci>122)
            {
                right-- ;
            }
            else if(word[left]!=word[right])
            {
                return false;
            }else{
                left++ ;
                right-- ;
            }
        }
        return true;
    }
    public static void Main(){
        bool res=isPalindrome("issi");
        Console.WriteLine($"result {res}");
    }
}
