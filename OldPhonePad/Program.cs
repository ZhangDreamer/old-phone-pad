namespace OldPhonePad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HanldeOldPhone.HandleOldPhonePad("33#"));        // Should output: E
            Console.WriteLine(HanldeOldPhone.HandleOldPhonePad("227*#"));       // Should output: B
            Console.WriteLine(HanldeOldPhone.HandleOldPhonePad("4433555 555666#"));  // Should output: HELLO
            Console.WriteLine(HanldeOldPhone.HandleOldPhonePad("8 88777444666*664#")); // Should output: TURING
        }
    }
}