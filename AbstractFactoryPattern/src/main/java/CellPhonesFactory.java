public class CellPhonesFactory extends FactoriesHandler {
    public CellPhone getCellPhone(CellPhoneTypes cellPhoneTypes) {
        if (cellPhoneTypes.equals(CellPhoneTypes.IPHONE)) {
            return new IPhone();
        } else if (cellPhoneTypes.equals(CellPhoneTypes.SAMSUNG)) {
            return new Samsung();
        } else {
            return null;
        }
    }

    public BodySpray getBodySpray(BodySprayTypes bodySprayTypes) {
        return null;
    }
}
