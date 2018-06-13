public class FactoriesManager {
    public static FactoriesHandler getFactory(FactoryTypes factoryTypes) {
        if (factoryTypes.equals(FactoryTypes.BODYSPRAY)) {
            return new BodySprayFactory();
        } else if (factoryTypes.equals(FactoryTypes.CELLPHONE)) {
            return new CellPhonesFactory();
        } else {
            return null;
        }

    }
}
