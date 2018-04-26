Rails.application.routes.draw do
  get 'admin/index'
  get 'main/index'

  resources :projects

  root 'main#index'
end
