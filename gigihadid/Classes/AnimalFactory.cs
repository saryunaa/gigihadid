namespace gigihadid.Classes
{
    class AnimalFactory
    {
        public static Animal CreateAnimal(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Lion();
                case 2:
                    return new Elephant();
                case 3:
                    return new Tiger();
                case 4:
                    return new Bear();
                case 5:
                    return new Wolf();
                default:
                    return null;
            }
        }
    }
}
