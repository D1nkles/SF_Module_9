try 
{
    throw new RankException();
}

catch (RankException ex) 
{
    Console.WriteLine(ex.GetType().ToString());
}

finally 
{

}