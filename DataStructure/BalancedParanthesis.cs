//-----------------------------------------------------------------------
// <copyright file="BalancedParanthesis.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    /// <summary>
    /// class for check balanced paranthesis
    /// </summary>
    class BalancedParanthesis
    {
        /// <summary>
        /// 
        /// </summary>
        public void balancedParanthesis()
        {
            try {

                Stack<char> stackObject = new Stack<char>();
                Utility utility = new Utility();
                int Top = -1,icnt = 0;
                bool isParanthesisPoped = false;

                Console.WriteLine("Enter the expression:");

                do {
                    
                    string Expression = Console.ReadLine();
                    char[] charArray = Expression.ToCharArray();
                    if (utility.IsExpression(Expression))
                    {
                        for (int i = 0; i < charArray.Length; i++)
                        {
                            if (charArray[i] == '(')
                            {
                                isParanthesisPoped = stackObject.push(charArray[i]);
                                if (isParanthesisPoped == true)
                                {
                                    Top++;
                                }
                            }
                            else if (charArray[i] == ')')
                            {
                                isParanthesisPoped = stackObject.pop();
                                if (isParanthesisPoped == true)
                                {
                                    Top--;
                                }

                            }
                        }
                        if (Top == -1)
                        {
                            Console.WriteLine("the expression is Balanced");
                        }
                        else
                        {
                            Console.WriteLine("the expression is not Balanced");
                        }
                        icnt = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Expression ..!");
                        Console.WriteLine("\n" + "Re-Enter the Expression ..!");
                    }
                } while (icnt==0);
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
