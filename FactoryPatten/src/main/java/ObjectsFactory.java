public class ObjectsFactory {

    public static Person getPerson(PersonTypes personTypes){
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
}
