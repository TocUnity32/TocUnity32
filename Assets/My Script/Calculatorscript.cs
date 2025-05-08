using UnityEngine;
using UnityEngine.UI;

public class Calculatorscript : MonoBehaviour
{
    public Text TextDisplay ;
    public float digit1 = 0f;
     public float digit2 = 0f;
     public string Opera;


    public void btnAddition ()
    {
        digit1 = float.Parse ( TextDisplay.text );
        Opera = " + ";
        TextDisplay.text = " ";
    }

   public void btnSubtract ()
    {
        digit1 = float.Parse ( TextDisplay.text );
        Opera = " - ";
        TextDisplay.text = " ";
    }
    public void btnMult ()
    {
        digit1 = float.Parse ( TextDisplay.text );
        Opera = " * ";
        TextDisplay.text = " ";
    }
    public void btnDivision ()
    {
        digit1 = float.Parse ( TextDisplay.text );
        Opera = " / ";
        TextDisplay.text = " ";
    }

    public void btnNum7()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "7";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"7";
    }

    }
     public void btnNum8()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "8";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"8";
    }

    }
    public void btnNum9()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "9";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"9";
    }

    }
     public void btnNum4()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "4";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"4";
    }

    }
     public void btnNum5()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "5";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"5";
    }

    }
     public void btnNum6()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "6";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text+"6";
    }

    }
     public void btnNum1()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "1";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"1";
    }

    }
     public void btnNum2()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "2";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"2";
    }

    }
     public void btnNum3()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "3";
    }
    else 
     {
        TextDisplay.text =TextDisplay.text +"3";
    }

    }
     public void btnNum0()
    { if (TextDisplay.text == "0")  
    {
        TextDisplay.text = "0";
    }
    else 
     {
        TextDisplay.text = TextDisplay.text +"0";
    }

    }

   public void btnBackSpace()
{
    if (TextDisplay.text.Length > 0)
    {
        TextDisplay.text = TextDisplay.text.Remove(TextDisplay.text.Length - 1);
    }
    
    // Check for empty string or single space
    if (TextDisplay.text == "" || TextDisplay.text == " ")
    {
        TextDisplay.text = " 0 ";
    }

}
public void btnClear()
    {

        TextDisplay.text = " 0 ";

    }
public void btnEntry()
{
    TextDisplay.text = "0";  
    digit1 = 0;
    digit2 = 0;

    string f = digit1.ToString();
    string s = digit2.ToString();
    
    // f = " ";
    // s = " ";
    
}
public void btnPM()
{
    float p = float.Parse(TextDisplay.text);
    TextDisplay.text = (-1 * p).ToString();
}
public void btnDec()
{
    if (!TextDisplay.text.Contains("."))
    {
        TextDisplay.text += ".";

    }
    
  }
  public void btnEquals()
{
    float answer = 0f;
    digit2 = float.Parse(TextDisplay.text);

    if (Opera == " + ")
    {
        answer = digit1 + digit2;
        TextDisplay.text = answer.ToString();
    }
        if (Opera == " - ")
    {
        answer = digit1 - digit2;
        TextDisplay.text = answer.ToString();
    }
        if (Opera == " * ")
    {
        answer = digit1 * digit2;
        TextDisplay.text = answer.ToString();
    }
        if (Opera == " / ")
    {
        if (digit2 != 0)
        {
            answer = digit1 / digit2;
            TextDisplay.text = answer.ToString();
        }

    }
}

}
