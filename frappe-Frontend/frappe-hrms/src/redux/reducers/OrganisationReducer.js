import { Organisation } from "../constants/organisation";

const initialOrganisationState = {
    OrganisationModel: [],
    loading: false,
};

export const OrganisationReducer = (state = initialOrganisationState, action) => {
    switch (action?.type) {
        case Organisation.LOADING.type:
            return { ...state, loading: true };
        case Organisation.REQUEST.type:
            return { ...state, OrganisationModel: action?.payload };
        case Organisation.SUCCESS.type:
            return { ...state, OrganisationModel: action?.payload, loading: false };
        case Organisation.ERROR.type:
            return { ...state, OrganisationModel: action?.payload, loading: false };
        default:
            return state;
    }
};
