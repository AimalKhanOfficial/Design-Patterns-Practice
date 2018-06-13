public class BodySprayFactory extends FactoriesHandler {
    public BodySpray getBodySpray(BodySprayTypes bodySprayTypes) {
        if (bodySprayTypes.equals(BodySprayTypes.AXE)) {
            return new Axe();
        } else if (bodySprayTypes.equals(BodySprayTypes.FOGG)) {
            return new Fogg();
        } else {
            return null;
        }
    }

    public CellPhone getCellPhone(CellPhoneTypes cellPhoneTypes) {
        return null;
    }
}
