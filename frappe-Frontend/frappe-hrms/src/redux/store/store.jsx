import { configureStore } from '@reduxjs/toolkit';
import { combineReducers } from 'redux';
import { thunk } from 'redux-thunk';  
import { LoginReducer } from '../reducers/LoginReducers';
import { SignupReducer } from '../reducers/SignUpReducers';
import { OrganisationReducer } from '../reducers/OrganisationReducer';
import { CompanyReducer } from '../reducers/CompanyReducers';

const rootReducer = combineReducers({
    auth: LoginReducer,
    signup : SignupReducer,
    Organisation : OrganisationReducer,
    Company : CompanyReducer
});
console.log('CompanyReducer');

const store = configureStore({
    reducer: rootReducer,
    middleware: (getDefaultMiddleware) => getDefaultMiddleware().concat(thunk),  
});

export default store;
