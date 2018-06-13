public class Main {
    public static void main(String[] args){

        //Getting the correct factory first
        FactoriesHandler factoriesHandler = FactoriesManager.getFactory(FactoryTypes.CELLPHONE);

        //Getting the correct Instance of cell phone
        CellPhone cellPhone = factoriesHandler.getCellPhone(CellPhoneTypes.IPHONE);

        //Calling the corresponding method to perfom some BL
        cellPhone.recievePhoneCall();
    }
}
