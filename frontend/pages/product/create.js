import {
  Alert,
  AlertIcon,
  Button,
  Flex,
  FormControl,
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

const ProductCreate = (props) => {
  const [serverResponse, setServerResponse] = useState(null);
  const toast = useToast();

  const formik = useFormik({
    initialValues: {
      name: "",
      manufacturer: "",
      style: "",
      purchasePrice: 0.0,
      salePrice: 0.0,
      quantityOnHand: 0,
      commissionPercentage: 0.0,
    },
    onSubmit: async (values) => {
      try {
        var response = await fetch(`${process.env.apiBaseUrl}/products/`, {
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
              description: "Product created successfully",
              status: "success",
              duration: 2000,
              isClosable: true,
            });
          }
        }
        return setServerResponse(response);
      } catch (err) {
        return setServerResponse(error);
      }
    },
  });

  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Heading color="gray.700" w="100%">
        Create Product
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
          <Flex justifyContent="center">
            <FormControl isRequired id="name">
              <FormLabel>Name</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.name}
              />
            </FormControl>
          </Flex>
          <Flex gridGap={5} justifyContent="center">
            <FormControl id="manufacturer">
              <FormLabel>Manufacturer</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.manufacturer}
              />
            </FormControl>
            <FormControl id="style">
              <FormLabel>Style</FormLabel>
              <Input
                type="text"
                onChange={formik.handleChange}
                value={formik.values.style}
              />
            </FormControl>
          </Flex>
          <Flex gridGap={5} justifyContent="center">
            <FormControl id="purchasePrice">
              <FormLabel>Purchase Price</FormLabel>
              <InputGroup>
                <InputLeftAddon children="$" />
                <Input
                  type="number"
                  onChange={formik.handleChange}
                  value={formik.values.purchasePrice}
                />
              </InputGroup>
            </FormControl>
            <FormControl id="salePrice">
              <FormLabel>Sale Price</FormLabel>
              <InputGroup>
                <InputLeftAddon children="$" />
                <Input
                  type="number"
                  onChange={formik.handleChange}
                  value={formik.values.salePrice}
                />
              </InputGroup>
            </FormControl>
          </Flex>
          <Flex gridGap={5} justifyContent="center">
            <FormControl id="commissionPercentage">
              <FormLabel>Commission Percentage</FormLabel>
              <InputGroup>
                <Input
                  type="number"
                  onChange={formik.handleChange}
                  value={formik.values.commissionPercentage}
                />
                <InputRightAddon children="%" />
              </InputGroup>
            </FormControl>
            <FormControl id="quantityOnHand">
              <FormLabel>Quantity On Hand</FormLabel>
              <InputGroup>
                <InputLeftAddon children="#" />
                <Input
                  type="number"
                  onChange={formik.handleChange}
                  value={formik.values.quantityOnHand}
                />
              </InputGroup>
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

export default ProductCreate;
