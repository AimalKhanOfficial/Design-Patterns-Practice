public class Main {
    public static void main(String[] args){

        //FACTORY PATTERN - falls in the category of Behavioral pattens!
        //Deals with the creation Logic

        //decoupling - Concept similar to dependency Injection
        Person person = ObjectsFactory.getPerson(PersonTypes.PROFESSOR);

        //Type casting to concrete class, just to set attributes
        ((Professor)person).setFirstName("Aimal");
        ((Professor)person).setLastName("Khan");

        //Calling the overrided method - Polymorphism
        System.out.println(person.sayName());
    }
}
