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
                Console.WriteLine("Enter the expression:");
                string Expression = Console.ReadLine();
                char[] charArray = Expression.ToCharArray();
                Stack<char> stackObject = new Stack<char>();
                
                int Top = -1;
                bool isParanthesisPoped = false;
                for (int i =0; i < charArray.Length; i++)
                {
                    if(charArray[i] == '(')
                    {
                        isParanthesisPoped=stackObject.push(charArray[i]);
                        if (isParanthesisPoped == true) {
                            Top++;
                        } 
                    }
                    else if(charArray[i] == ')')
                    {
                        isParanthesisPoped = stackObject.pop();
                        if (isParanthesisPoped == true) {
                            Top--;
                        }
                        
                    }
                    Console.WriteLine("The Display funcion:");
                    stackObject.Display();
                    
                }
                if (Top == -1) {
                    Console.WriteLine("the expression is Balanced");
                }
                else
                {
                    Console.WriteLine("the expression is not Balanced");
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
