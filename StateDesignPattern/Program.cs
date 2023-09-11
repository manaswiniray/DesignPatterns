namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            StateController controller = new StateController();
            IUserState userState = controller.userStateController();

            user.ChangeState(userState);
            Console.WriteLine(user.GetStatus());


        }
    }
}