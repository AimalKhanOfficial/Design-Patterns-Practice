public class ObjectsFactory {

    //A static self reference to use for all
    private static ObjectsFactory objectsFactoryInstance = new ObjectsFactory();

    //A private constructor so that class cannot be initialized!
    private ObjectsFactory(){ }

    public Person getPerson(PersonTypes personTypes){
        if(personTypes.equals(PersonTypes.PROFESSOR)){
            return new Professor();
        }
        else if(personTypes.equals(PersonTypes.STUDENT)){
            return new Student();
        }
        else {
            return null;
        }
    }

    public static ObjectsFactory getObjectsFactoryInstance() {
        return objectsFactoryInstance;
    }
}
