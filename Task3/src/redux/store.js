import { createStore, applyMiddleware, combineReducers } from 'redux';
import { thunk } from 'redux-thunk';  // Cập nhật ở đây
import postReducer from './reducers/postReducer';

const rootReducer = combineReducers({
    posts: postReducer,
});

const store = createStore(rootReducer, applyMiddleware(thunk));  // Giữ nguyên phần này

export default store;
