import {
  Alert,
  AlertIcon,
  Box,
  Button,
  Flex,
  FormControl,
  FormHelperText,
  FormLabel,
  Heading,
  Input,
  InputGroup,
  InputLeftAddon,
  InputRightAddon,
  SimpleGrid,
  useToast,
} from "@chakra-ui/react";
import { useFormik } from "formik";
import { useState } from "react";

const CreateSale = (props) => {
  const [serverResponse, setServerResponse] = useState(null);
  const toast = useToast();

  const formik = useFormik({
    initialValues: {
      productId: 0,
      customerId: 0,
      salespersonId: 0,
    },
    onSubmit: async (values) => {
      try {
        var response = await fetch(`${process.env.apiBaseUrl}/sales/`, {
          method: "POST",
          body: JSON.stringify(values),
          headers: {
            "Content-Type": "application/json",
          },
        });

        if (response.status === 200) {
          {
            toast({
              title: "Create Successful",
              description: "Sale created succesfully",
              status: "success",
              duration: 2000,
              isClosable: true,
            });
          }
        } else {
          toast({
            title: "Create Unsuccessful",
            description: JSON.stringify(await response.json()),
            status: "error",
            duration: 2000,
            isClosable: true,
          });
        }
        return setServerResponse(response);
      } catch (error) {
        return setServerResponse(error);
      }
    },
  });

  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Heading color="gray.700" w="100%">
        Create Sale
      </Heading>
      {serverResponse?.status == 200 ? (
        <Alert mt={2} borderRadius="md" status="success">
          <AlertIcon />
          Data uploaded to the server.
        </Alert>
      ) : null}
      <form style={{ width: `100%` }} onSubmit={formik.handleSubmit}>
        <SimpleGrid
          mt="3"
          w="100%"
          justifyContent="center"
          columns={1}
          spacing={5}
        >
          <Flex gridGap={5} justifyContent="center">
            <FormControl isRequired id="productId">
              <FormLabel>Product Id</FormLabel>
              <Input
                type="number"
                onChange={formik.handleChange}
                value={formik.values.productId}
              />
            </FormControl>
            <FormControl isRequired id="customerId">
              <FormLabel>Customer Id</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.customerId}
              />
            </FormControl>
            <FormControl isRequired id="salespersonId">
              <FormLabel>Salesperson Id</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.salespersonId}
              />
            </FormControl>
          </Flex>
          <Flex justifyContent="center" mt="3">
            <Button
              disabled={formik.isSubmitting}
              bgColor="teal.400"
              px={3}
              color="teal.900"
              type="submit"
            >
              Save
            </Button>
          </Flex>
        </SimpleGrid>
      </form>
    </Flex>
  );
};

export default CreateSale;
