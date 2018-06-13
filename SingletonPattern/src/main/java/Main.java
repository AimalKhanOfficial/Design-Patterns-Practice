public class Main {
    public static void main(String[] args){

        //Provides the shared instance
        ObjectsFactory objectsFactory = ObjectsFactory.getObjectsFactoryInstance();

        Person person = objectsFactory.getPerson(PersonTypes.PROFESSOR);

        //Type casting to concrete class, just to set attributes
        ((Professor)person).setFirstName("Aimal");
        ((Professor)person).setLastName("Khan");

        //Calling the overrided method - Polymorphism
        System.out.println(person.sayName());
    }
}
